using GTADealership.Data.Interfaces;
using GTADealership.Data.MockLists;
using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.Mock_Repos
{
    public class MakeRepositoryMock : IMakeRepository
    {
        public List<Make> GetAllMakes()
        {
            return GTAMakeList.GTAMakes;
        }
    }
}
