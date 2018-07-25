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
    public class PurchaseTransactionEF
    {
        [Key]
        public int PurchaseTransactionId { get; set; }
        public int UserId { get; set; }        
        public int CustomerId { get; set; }        
        public int VehicleId { get; set; }
        public decimal SalesPrice { get; set; }        
        public int PaymentTypeId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual CustomerEF Customer { get; set; }
        [ForeignKey("VehicleId")]
        public virtual VehicleEF Vehicle { get; set; }
        [ForeignKey("PaymentTypeId")]
        public virtual PaymentTypeEF PaymentType { get; set; }
    }


}

