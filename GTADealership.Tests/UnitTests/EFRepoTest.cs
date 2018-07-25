using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GTADealership.Data.EFRepos;
using GTADealership.Data.EF_Models;
using GTADealership.Models.Tables;

namespace GTADealership.Tests.UnitTests
{
    [TestFixture]
    public class EFRepoTest
    {
        [Test]
        public void CanLoadVehicles()
        {
            var myRepo = new GTADealershipEntities();

            var vehicles = myRepo.Vheicles.ToList();

            Assert.AreEqual(3, vehicles.Count);
            //Assert.AreEqual("TN", states[0].StateId);
            //Assert.AreEqual("Kentucky", states[1].StateName);
        }

        [Test]
        public void CanAddVehicle()
        {
            var myRepo = new VehicleRepoEF();

            Vehicle vehicleToAdd = new Vehicle();

            vehicleToAdd.VIN = "111111111111";
            vehicleToAdd.Year = "1999";
            vehicleToAdd.Mileage = 9999;
            vehicleToAdd.MakeName = "Ford";
            vehicleToAdd.ModelName = "Charger";
            vehicleToAdd.IsNew = true;
            vehicleToAdd.ColorName = "Black";
            vehicleToAdd.BodyStyleName = "Sedan";
            vehicleToAdd.TransName = "Manual";
            vehicleToAdd.InteriorName = "Cloth";
            vehicleToAdd.SalesPrice = 1999.99M;
            vehicleToAdd.MSRP = 1999.99M;
            vehicleToAdd.ImageName = "Charger.jpg";
            vehicleToAdd.IsFeatured = true;
            vehicleToAdd.StatusName = "Sold";

            myRepo.AddVehicle(vehicleToAdd);

            Assert.AreEqual(26, vehicleToAdd.VehicleId);
        }
    }
}
