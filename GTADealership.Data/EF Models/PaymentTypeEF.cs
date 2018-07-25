using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class PaymentTypeEF
    {
        [Key]
        public int PaymentTypeId { get; set; }
        public string PaymentName { get; set; }
    }
}
