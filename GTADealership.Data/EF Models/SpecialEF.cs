using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.EF_Models
{
    public class SpecialEF
    {
        [Key]
        public int SpeicialId { get; set; }
        public string SpecialTitle { get; set; }
        public string SpecialDescription { get; set; }
    }
}
