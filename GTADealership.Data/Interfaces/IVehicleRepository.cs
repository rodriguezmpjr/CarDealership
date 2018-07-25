using GTADealership.Models.Tables;
using GTADealership.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.Interfaces
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetAllVehicles();
        SpecialsAndVehicles GetSpecialsAndFeaturedVehicles();
    };
}
