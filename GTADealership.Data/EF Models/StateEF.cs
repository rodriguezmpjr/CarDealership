using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.EF_Models
{
    public class StateEF
    {
        [Key]
        public string StateId { get; set; }
        public string StateName { get; set; }
    }
}
