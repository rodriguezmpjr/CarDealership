using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class TransEF
    {
        [Key]
        public int TransId { get; set; }
        public string TransName { get; set; }
    }
}
