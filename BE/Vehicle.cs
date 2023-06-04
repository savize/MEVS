using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }

        public static List<string> BrandNames { get; } = new List<string>
        {
            "BMW",
            "Ferrari",
            "Geely",
            "GWM",
            "Honda",
            "Hyundai",
            "Kia",
            "Mazda",
            "Mercedes Benz",
            "Mini Cooper",
            "MINI Countryman",
            "Nissan",
            "Peugeot",
            "Porsche",
            "Renault",
            "Tesla",
            "Volvo",
        };

        public string Model { get; set; }
        public string Address { get; set; }

        public User EVUsers { get; set; }
    }
}
