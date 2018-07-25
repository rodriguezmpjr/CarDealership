using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTAVehicleModelList
    {
        public static List<VehicleModel> GTAVehicleModels { get; set; }

        static GTAVehicleModelList()
        {
            GTAVehicleModels = new List<VehicleModel>()
            {
                new VehicleModel()
                {
                    VehicleModelId = 1,
                    ModelName = "Charger",
                    MakeId = 1,
                    SpecialId = 1
                },
                new VehicleModel()
                {
                    VehicleModelId = 2,
                    ModelName = "Encore",
                    MakeId = 2,
                    SpecialId = 2
                },
                new VehicleModel()
                {
                    VehicleModelId = 3,
                    ModelName = "Corvette",
                    MakeId = 3,
                    SpecialId = 3
                },
                new VehicleModel()
                {
                    VehicleModelId = 4,
                    ModelName = "Armada",
                    MakeId = 4,
                    SpecialId = 4
                }
            };
        }
    }
}
