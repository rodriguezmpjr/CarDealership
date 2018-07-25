using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class BodyStyleEF
    {
        [Key]
        public int BodyStyleId { get; set; }
        public string BodyStyleName { get; set; }
    }
}
