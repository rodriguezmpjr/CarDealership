using GTADealership.Data.Interfaces;
using GTADealership.Data.Mock_Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.Factories
{
    public class TransmissionRepositoryFactory
    {
        public static ITransmissionRepository GetRepository()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new TransmissionRepositoryMock();
                case "PROD":
                    throw new Exception("PROD repo not implemented");
                default:
                    throw new Exception("Could not find valid RepositoryType configuration value.");
            }
        }
    }
}
