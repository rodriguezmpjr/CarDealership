using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class VehicleStatusEF
    {
        [Key]
        public int VehicleStatusId { get; set; }
        public string VehicleStatusName { get; set; }
    }
}
