using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product.DTO
{
    public class LocationDTO
    {

        public string _id { get; set; }

        public string Description { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
