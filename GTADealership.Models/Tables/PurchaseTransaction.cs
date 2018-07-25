using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class PurchaseTransaction
    {
        public int PurchaseTransactionId { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public decimal SalesPrice { get; set; }
        public int PaymentTypeId { get; set; }
    }
}
