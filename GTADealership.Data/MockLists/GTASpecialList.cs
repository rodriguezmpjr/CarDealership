using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTASpecialList
    {
        public static List<Special> GTASpecials { get; set; }

        static GTASpecialList()
        {
            GTASpecials = new List<Special>()
            {
                new Special()
                {
                    SpecialID = 1,
                    SpecialTitle = "$5000 Factory Rebate"
                },
                new Special()
                {
                    SpecialID = 2,
                    SpecialTitle = "$0 Down/$299 month"
                },
                new Special()
                {
                    SpecialID = 3,
                    SpecialTitle = "BOGO"
                },
            };


        }
    }
}
