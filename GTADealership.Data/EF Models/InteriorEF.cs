using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class InteriorEF
    {
        [Key]
        public int InteriorId { get; set; }
        public string InteriorName { get; set; }
    }
}
