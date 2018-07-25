using GTADealership.Data.Interfaces;
using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.Mock_Repos
{
    public class StateRepositoryMock : IStateRepository
    {
        public List<State> GetAllStates()
        {
            return GTAStateList.GTAStates;
        }
    }
}
