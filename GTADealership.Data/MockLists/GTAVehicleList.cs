using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTAVehicleList
    {
        public static List<Vehicle> GTAVehicles { get; set; }

        static GTAVehicleList()
        {
            GTAVehicles = new List<Vehicle>()
            {
                new Vehicle()
                {
                    VehicleId = 1,
                    VIN = "1VIN",
                    Year = "2016",
                    Mileage = 1,
                    MakeName = "Dodge",
                    ModelName = "Charger",
                    IsNew = false,
                    ColorName = "Black",
                    BodyStyleName = "Sedan",
                    TransName = "Automatic",
                    InteriorName = "Leather(black)",
                    SalesPrice = 34999.99M,
                    MSRP = 36999.99M,
                    //Description = "1blah, blah, blah",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    StatusName = "Available"
                },
                new Vehicle()
                {
                    VehicleId = 2,
                    VIN = "2VIN",
                    Year = "2015",
                    Mileage = 2,
                    MakeName = "Buick",
                    ModelName = "Encore",
                    IsNew = false,
                    ColorName = "Grey",
                    BodyStyleName = "SUV",
                    TransName = "Automatic",
                    InteriorName = "Leather(Grey)",
                    SalesPrice = 24999.99M,
                    MSRP = 26999.99M,
                    //Description = "2blah, blah, blah",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    StatusName = "Available"
                },
                new Vehicle()
                {
                    VehicleId = 3,
                    VIN = "3VIN",
                    Year = "2018",
                    Mileage = 3,
                    MakeName = "Chevorlet",
                    ModelName = "Corvette",
                    IsNew = true,
                    ColorName = "Red",
                    BodyStyleName = "Sports",
                    TransName = "Manual",
                    InteriorName = "Leather(black)",
                    SalesPrice = 54999.99M,
                    MSRP = 59999.99M,
                    //Description = "3blah, blah, blah",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    StatusName = "Available"
                },
                new Vehicle()
                {
                    VehicleId = 4,
                    VIN = "4VIN",
                    Year = "2018",
                    Mileage = 4,
                    MakeName = "Nissan",
                    ModelName = "Armada",
                    IsNew = true,
                    ColorName = "White",
                    BodyStyleName = "SUV",
                    TransName = "Automatic",
                    InteriorName = "Leather(Dark grey)",
                    SalesPrice = 44999.99M,
                    MSRP = 46999.99M,
                    //Description = "4blah, blah, blah",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    StatusName = "Available"
                },
                new Vehicle()
                {
                    VehicleId = 1,
                    VIN = "1VIN",
                    Year = "2016",
                    Mileage = 1,
                    MakeName = "Dodge",
                    ModelName = "Charger",
                    IsNew = false,
                    ColorName = "Black",
                    BodyStyleName = "Sedan",
                    TransName = "Automatic",
                    InteriorName = "Leather(black)",
                    SalesPrice = 34999.99M,
                    MSRP = 36999.99M,
                    //Description = "1blah, blah, blah",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    StatusName = "Available"
                },
                new Vehicle()
                {
                    VehicleId = 2,
                    VIN = "2VIN",
                    Year = "2015",
                    Mileage = 2,
                    MakeName = "Buick",
                    ModelName = "Encore",
                    IsNew = false,
                    ColorName = "Grey",
                    BodyStyleName = "SUV",
                    TransName = "Automatic",
                    InteriorName = "Leather(Grey)",
                    SalesPrice = 24999.99M,
                    MSRP = 26999.99M,
                    //Description = "2blah, blah, blah",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    StatusName = "Available"
                },
                new Vehicle()
                {
                    VehicleId = 3,
                    VIN = "3VIN",
                    Year = "2018",
                    Mileage = 3,
                    MakeName = "Chevorlet",
                    ModelName = "Corvette",
                    IsNew = true,
                    ColorName = "Red",
                    BodyStyleName = "Sports",
                    TransName = "Manual",
                    InteriorName = "Leather(black)",
                    SalesPrice = 54999.99M,
                    MSRP = 59999.99M,
                    //Description = "3blah, blah, blah",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    StatusName = "Available"
                },
                new Vehicle()
                {
                    VehicleId = 4,
                    VIN = "4VIN",
                    Year = "2018",
                    Mileage = 4,
                    MakeName = "Nissan",
                    ModelName = "Armada",
                    IsNew = true,
                    ColorName = "White",
                    BodyStyleName = "SUV",
                    TransName = "Automatic",
                    InteriorName = "Leather(Dark grey)",
                    SalesPrice = 44999.99M,
                    MSRP = 46999.99M,
                    //Description = "4blah, blah, blah",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    StatusName = "Available"
                },
            };
        }
    }
}
