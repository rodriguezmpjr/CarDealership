using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTAMakeList
    {
        public static List<Make> GTAMakes { get; set; }

        static GTAMakeList()
        {
            GTAMakes = new List<Make>()
            {
                new Make()
                {
                    MakeId = 1,
                    MakeName = "Dodge"
                },
                new Make()
                {
                    MakeId = 2,
                    MakeName = "Buick"
                },
                new Make()
                {
                    MakeId = 3,
                    MakeName = "Chevorlet"
                },
                new Make()
                {
                    MakeId = 4,
                    MakeName = "Nissan"
                }
            };
        }
    }
}
