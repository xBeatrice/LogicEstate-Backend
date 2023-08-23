using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using LogicEstate.Core;
using LogicEstate.Core.Interfaces;
using LogicEstate.Models;
using Newtonsoft.Json;

namespace LogicEstate.Controllers
{
    public class HomesController : Controller
    {
        private IHomesManager homesManager = new HomesManager();

        // GET: Homes/Index
        public async Task<JsonResult> Index()
        {
            List<HomeEntity> homes = await homesManager.GetListAsync();
            return Json(homes, JsonRequestBehavior.AllowGet);
        }

        // POST: Homes/Create
        [HttpPost]
        public async Task<HomeEntity> Create(HomeModel homeModel)
        {
            return await homesManager.CreateAsync(homeModel);
        }


        // GET: Homes/Details/5
        public async Task<HomeEntity> Details(int id)
        {
            return await homesManager.GetDetailsAsync(id);
        }

        // PUT: Homes/Edit/5
        [HttpPost]
        public async Task<HomeEntity> Edit(int id, HomeModel homeModel)
        {
            return await homesManager.EditAsync(id, homeModel);
        }

        

        // DELETE: Homes/Delete/5
        [HttpGet]
        public async Task Delete(int id)
        {
             await homesManager.DeleteAsync(id);
        }
    }
}
