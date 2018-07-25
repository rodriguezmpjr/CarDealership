using GTADealership.Data.Interfaces;
using GTADealership.Data.MockLists;
using GTADealership.Models.Tables;
using GTADealership.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.Mock_Repos
{
    public class VehicleRepositoryMock : IVehicleRepository
    {
        public List<Vehicle> GetAllVehicles()
        {
            return  GTAVehicleList.GTAVehicles;
        }

        public SpecialsAndVehicles GetSpecialsAndFeaturedVehicles()
        {
            var model = new SpecialsAndVehicles
            {
                FeaturedVehicles = GTAVehicleList.GTAVehicles.Where(v => v.IsFeatured == true).ToList(),
                Specials = GTASpecialList.GTASpecials.ToList()
            };

            return model;
        }
    }
}
