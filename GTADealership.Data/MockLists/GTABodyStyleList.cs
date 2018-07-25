using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTABodyStyleList
    {
        public static List<BodyStyle> GTABodyStyles { get; set; }

        static GTABodyStyleList()
        {
            GTABodyStyles = new List<BodyStyle>()
            {
                new BodyStyle()
                {
                    BodyStyleId = 1,
                    BodyStyleName = "Sedan"
                },
                new BodyStyle()
                {
                    BodyStyleId = 2,
                    BodyStyleName = "Truck"
                },
                new BodyStyle()
                {
                    BodyStyleId = 3,
                    BodyStyleName = "SUV"
                }

            };
        }
    }
}
