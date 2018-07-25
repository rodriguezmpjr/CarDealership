using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data
{
    public static class GTAStateList
    {
        public static List<State> GTAStates { get; set; }

        static GTAStateList()
        {
            GTAStates = new List<State>()
            {
                new State()
                {
                    StateId = "TN",
                    StateName = "Tennessee"
                },
                new State()
                {
                    StateId = "KY",
                    StateName = "Kentucky"
                },
                new State()
                {
                    StateId = "GA",
                    StateName = "Georgia"
                },

            };
        }
    }
}
