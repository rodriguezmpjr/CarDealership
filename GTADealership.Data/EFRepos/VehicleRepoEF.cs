using GTADealership.Data.EF_Models;
using GTADealership.Data.Interfaces;
using GTADealership.Models.Tables;
using GTADealership.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.EFRepos
{
    public class VehicleRepoEF : IVehicleRepository
    {
        public List<Vehicle> GetAllVehicles()
        {
            var myRepo = new GTADealershipEntities();

            var repoToList = myRepo.Vheicles.ToList();

            List<Vehicle> returnList = new List<Vehicle>();

            foreach (VehicleEF v in repoToList)
            {
                returnList.Add(new Vehicle
                {
                    VehicleId = v.VehicleId,
                    VIN = v.VIN,
                    Year = v.Description,
                    Mileage = v.Milage,
                    ModelName = v.VModel.ModelName,
                    MakeName = v.VModel.Make.MakeName,
                    IsNew = v.IsNew,
                    ColorName = v.Color.ColorName,
                    BodyStyleName = v.BodyStyle.BodyStyleName,
                    TransName = v.Trans.TransName,
                    InteriorName = v.Interior.InteriorName,
                    SalesPrice = v.SalesPrice,
                    MSRP = v.MSRP,
                    //Year = v.Description,
                    ImageName = v.ImageName,
                    IsFeatured = v.IsFeatured,
                    StatusName = v.VehicleStatus.VehicleStatusName

                });
            }

            return returnList;
        }

        public SpecialsAndVehicles GetSpecialsAndFeaturedVehicles()
        {
            var model = new SpecialsAndVehicles
            {
                FeaturedVehicles = GetAllVehicles().Where(v => v.IsFeatured == true).ToList(),
                Specials = GetAllSpecials().ToList()
            };

            return model;
        }
        

        public List<Special> GetAllSpecials()
        {
            var myRepo = new GTADealershipEntities();

            var specialsList = myRepo.Specials.ToList();

            List<Special> specialsToReturn = new List<Special>();

            foreach (SpecialEF s in specialsList)
            {
                specialsToReturn.Add(new Special
                {
                    SpecialID = s.SpeicialId,
                    SpecialTitle = s.SpecialTitle,
                    SpecialDescription = s.SpecialDescription

                });
            }

            return specialsToReturn;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            var myRepo = new GTADealershipEntities();

            var make = myRepo.Makes.FirstOrDefault(m => m.MakeName == vehicle.MakeName);
            if (make == null)
            {
                make = myRepo.Makes.Add(new MakeEF { MakeName = vehicle.MakeName });
                myRepo.SaveChanges();
            }

            var vehicleModel = myRepo.VModels.FirstOrDefault(m => m.ModelName == vehicle.ModelName);
            var vColor = myRepo.Colors.FirstOrDefault(c => c.ColorName == vehicle.ColorName);
            var vBodyStyle = myRepo.BodyStyles.FirstOrDefault(b => b.BodyStyleName == vehicle.BodyStyleName);
            var vTrans = myRepo.Trans.FirstOrDefault(t => t.TransName == vehicle.TransName);
            var vInterior = myRepo.Interiors.FirstOrDefault(i => i.InteriorName == vehicle.InteriorName);
            var vStatus = myRepo.VehicleStatuses.FirstOrDefault(s=>s.VehicleStatusName == vehicle.StatusName);

            var vehicleAdd = myRepo.Vheicles.Add(
                new VehicleEF
                {
                    VehicleId = vehicle.VehicleId,
                    VIN = vehicle.VIN,
                    Milage = vehicle.Mileage,
                    VModel_Id = vehicleModel.VModelId,
                    IsNew = vehicle.IsNew,
                    ColorId = vColor.ColorId,
                    BodyStyleId = vBodyStyle.BodyStyleId,
                    TransId = vTrans.TransId,
                    InteriorId = vInterior.InteriorId,
                    SalesPrice = vehicle.SalesPrice,
                    MSRP = vehicle.MSRP,
                    Description = vehicle.Year,
                    ImageName = vehicle.ImageName,
                    IsFeatured = vehicle.IsFeatured,
                    VehicleStatusId = vStatus.VehicleStatusId                    
                });

            myRepo.SaveChanges(); 
        }
    }    
}






