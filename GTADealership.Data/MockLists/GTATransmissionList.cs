using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTATransmissionList
    {
        public static List<Transmission> GTATransmissions { get; set; }
        
        static GTATransmissionList()
        {
            GTATransmissions = new List<Transmission>()
            {
                new Transmission()
                {
                    TransId = 1,
                    TransName = "Manual(5-speed)"
                },
                new Transmission()
                {
                    TransId = 2,
                    TransName = "Manual(6-speed)"
                },
                new Transmission()
                {
                    TransId = 3,
                    TransName = "Automatic"
                }
            };
        }
    }
}
