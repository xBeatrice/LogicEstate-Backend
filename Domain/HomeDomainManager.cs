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

        public HomeEntity UpdateHome(HomeEntity home, HomeModel homeModel)
        {
            home.Title = homeModel.Title;
            home.Description = homeModel.Description;
            home.Images = homeModel.Images;
            home.Latitude = homeModel.Latitude;
            home.Longitude = homeModel.Longitude;
            home.City = homeModel.City;
            home.Price = homeModel.Price;
            home.NumberOfRooms = homeModel.NumberOfRooms;
            home.SurfaceSquareMeters = homeModel.SurfaceSquareMeters;

            return home;
        }
    }
}