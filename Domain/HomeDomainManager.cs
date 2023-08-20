using LogicEstate.Core;
using LogicEstate.Domain.Interfaces;
using LogicEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogicEstate.Domain
{
    public class HomeDomainManager : IHomeDomainManager
    {
        public HomeEntity CreateHome(HomeModel homeModel)
        {
            return new HomeEntity()
            {
                Title = homeModel.Title,
                Description = homeModel.Description,
                Images = homeModel.Images,
                Latitude = homeModel.Latitude,
                Longitude = homeModel.Longitude,
                City = homeModel.City,
                Price = homeModel.Price,
                NumberOfRooms = homeModel.NumberOfRooms,
                SurfaceSquareMeters = homeModel.SurfaceSquareMeters
            };
        }
    }
}