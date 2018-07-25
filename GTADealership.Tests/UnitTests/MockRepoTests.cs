using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTADealership.Data.Mock_Repos;
using NUnit.Framework;

namespace GTADealership.Tests.UnitTests
{
    [TestFixture]
    public class MockRepoTests
    {
        [Test]
        public void CanLoadStates()
        {
            var myRepo = new StateRepositoryMock();

            var states = myRepo.GetAllStates();

            Assert.AreEqual(3, states.Count);
            Assert.AreEqual("TN", states[0].StateId);
            Assert.AreEqual("Kentucky", states[1].StateName);
        }

        [Test]
        public void CanLoadColors()
        {
            var myRepo = new ColorRepositoryMock();

            var colors = myRepo.GetAllColors();

            Assert.AreEqual(3, colors.Count);
            Assert.AreEqual("Red", colors[0].ColorName);
        }

        //[Test]
        //public void CanLoadFeaturedVehicles()
        //{
        //    var myRepo = new VehicleRepositoryMock();

        //    var featuredVehicles = myRepo.GetSpecialsAndFeaturedVehicles();

        //    Assert.AreEqual(8, myRepo.Count);
        //}
    }    
}
