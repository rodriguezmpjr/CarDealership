using GTADealership.Data.Factories;
using GTADealership.Data.Interfaces;
using GTADealership.Models.Tables;
using GTADealership.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GTADealership.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IVehicleRepository myRepo = VehicleRepositoryFactory.GetRepository();
            SpecialsAndVehicles model = myRepo.GetSpecialsAndFeaturedVehicles();         

            return View(model);
        }

        //public ActionResult Specials()
        //{


        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}