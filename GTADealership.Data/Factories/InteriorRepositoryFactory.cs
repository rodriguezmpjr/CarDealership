﻿using GTADealership.Data.Interfaces;
using GTADealership.Data.Mock_Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.Factories
{
    public class InteriorRepositoryFactory
    {
        public static IInteriorRepository GetRepository()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new InteriorRepositoryMock();
                case "PROD":
                    throw new Exception("PROD repo not implemented");
                default:
                    throw new Exception("Could not find valid RepositoryType configuration value.");
            }
        }
    }
}
