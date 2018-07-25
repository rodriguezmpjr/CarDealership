using GTADealership.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using GTADealership.Data.Mock_Repos;

namespace GTADealership.Data.Factories
{
    public class StateRepositoryFactory
    {
        public static IStateRepository GetRepository()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new StateRepositoryMock();
                case "PROD":
                    throw new Exception("PROD repo not implemented");
                default:
                    throw new Exception("Could not find valid RepositoryType configuration value.");
            }       
        }
    }
}
