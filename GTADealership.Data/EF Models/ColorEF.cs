using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class ColorEF
    {
        [Key]
        public int ColorId { get; set; }
        public String ColorName { get; set; }
    }
}
