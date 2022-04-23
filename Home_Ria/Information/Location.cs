using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Ria
{
    class Location
    {
        public Location(string city, string district, string street, string homeNumber)
        {
            City = city;
            District = district;
            Street = street;
            HomeNumber = homeNumber;
        }
        public Location()
        {
            City = String.Empty;
            District = String.Empty;
            Street = String.Empty;
            HomeNumber = String.Empty;
        }

        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }

    }
}
