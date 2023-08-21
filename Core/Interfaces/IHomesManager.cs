using LogicEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEstate.Core.Interfaces
{
    public interface IHomesManager
    {
        Task<List<HomeEntity>> GetListAsync();

        Task<HomeEntity> CreateAsync(HomeModel homeModel);

        Task<HomeEntity> GetDetailsAsync(int id);

        Task<HomeEntity> EditAsync(int id, HomeModel homeModel);

        Task DeleteAsync(int id);
    }
}
