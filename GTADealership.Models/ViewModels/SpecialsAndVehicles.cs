using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.ViewModels
{
    public class SpecialsAndVehicles
    {
        //public string Year { get; set; }
        //public string MakeName { get; set; }
        //public string ModelName { get; set; }
        //public decimal SalesPrice { get; set; }
        //public string SpecialTitle { get; set; }
        //public string SpecialDescription { get; set; }

        public List<Vehicle> FeaturedVehicles { get; set; }
        public List<Special> Specials { get; set; }
    }
}
