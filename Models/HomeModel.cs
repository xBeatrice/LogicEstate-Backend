using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogicEstate.Models
{
    public class HomeModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Images { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
        public decimal Price { get; set; }
        public int ConstructionYear { get; set; }
        public int Floor { get; set; }
        public int NumberOfRooms { get; set; }
        public int SurfaceSquareMeters { get; set; }
    }
}