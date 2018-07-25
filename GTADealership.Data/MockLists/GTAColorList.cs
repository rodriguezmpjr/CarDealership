using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTAColorList
    {
        public static List<Color> GTAColors { get; set; }

        static GTAColorList()
        {
            GTAColors = new List<Color>()
            {
                new Color()
                {
                    ColorId = 1,
                    ColorName = "Red"
                },
                new Color()
                {
                    ColorId = 2,
                    ColorName = "Green"
                },
                new Color()
                {
                    ColorId = 3,
                    ColorName = "Blue"
                }

            };
        }
    }
}
