using LogicEstate.Core.Interfaces;
using LogicEstate.Domain;
using LogicEstate.Domain.Interfaces;
using LogicEstate.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LogicEstate.Core
{
    public class HomesManager : IHomesManager
    {
        private IHomeDomainManager homesManager = new HomeDomainManager();
        private AppDbContext db = new AppDbContext();

        public async Task<List<HomeEntity>> GetListAsync()
        {
            return await db.Homes.ToListAsync();
        }

        public async Task<HomeEntity> CreateAsync(HomeModel createHomeModel)
        {
            var home = homesManager.CreateHome(createHomeModel);

            db.Homes.Add(home);

            await db.SaveChangesAsync();

            return home;
        }

        public async Task<HomeEntity> GetDetailsAsync(int id)
        {
            return await db.Homes.FindAsync(id);
        }

        public async Task<HomeEntity> EditAsync(int id, HomeModel updateHomeModel)
        {
            var home = await db.Homes.FindAsync(id);

            if (home == null)
            {
                throw new Exception("Home not found.");
            }

            var updatedHome = homesManager.UpdateHome(home, updateHomeModel);

            await db.SaveChangesAsync();

            return updatedHome;
        }


        public async Task DeleteAsync ( int id)
        {
            HomeEntity homeModel = db.Homes.Find(id);

            db.Homes.Remove(homeModel);

            await db.SaveChangesAsync();
        }
    }
}