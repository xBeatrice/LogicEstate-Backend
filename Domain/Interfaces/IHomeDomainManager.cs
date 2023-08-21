using LogicEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogicEstate.Domain.Interfaces
{
    public interface IHomeDomainManager
    {
        HomeEntity CreateHome(HomeModel createHomeModel);

        HomeEntity UpdateHome(HomeEntity home, HomeModel editHomeModel);
    }

}