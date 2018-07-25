using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.EF_Models
{
    public class VModelEF
    {
        [Key]
        public int VModelId { get; set; }
        public string ModelName { get; set; }
      
        public int MakeId { get; set; }
 
        public int SpecialId { get; set; }

        [ForeignKey("MakeId")]
        public virtual MakeEF Make { get; set; }
        [ForeignKey("SpecialId")]
        public virtual SpecialEF Special { get; set; }
    }
}
