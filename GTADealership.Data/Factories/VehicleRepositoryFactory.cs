using GTADealership.Data.EFRepos;
using GTADealership.Data.Interfaces;
using GTADealership.Data.Mock_Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.Factories
{
    public class VehicleRepositoryFactory
    {
        public static IVehicleRepository GetRepository()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new VehicleRepositoryMock();
                case "PROD":
                    return new VehicleRepoEF();
                default:
                    throw new Exception("Could not find valid RepositoryType configuration value.");
            }
        }
    }
}
