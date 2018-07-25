using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class VehicleModel
    {
        public int VehicleModelId { get; set; }
        public string ModelName { get; set; }
        public int MakeId { get; set; }
        public int SpecialId { get; set; }
    }
}
