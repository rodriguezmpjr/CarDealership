using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTAInteriorList
    {

        public static List<Interior> GTAInteriors { get; set; }

        static GTAInteriorList()
        {
            GTAInteriors = new List<Interior>()
            {
                new Interior()
                {
                    InteriorId = 1,
                    InteriorName = "Leather(tan)"
                },
                new Interior()
                {
                    InteriorId = 2,
                    InteriorName = "Cloth(tan)"
                },
                new Interior()
                {
                    InteriorId = 3,
                    InteriorName = "Suede(tan)"
                }

            };
        }

    }
}
