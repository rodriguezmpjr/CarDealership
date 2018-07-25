using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class MakeEF
    {
        [Key]
        public int MakeId { get; set; }
        public string MakeName { get; set; }
    }
}
