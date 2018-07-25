using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTAPurchaseTransactionList
    {
        public static List<PurchaseTransaction> GTAPurchaseTransactions { get; set; }

        static GTAPurchaseTransactionList()
        {
            GTAPurchaseTransactions = new List<PurchaseTransaction>()
            {
                new PurchaseTransaction()
                {
                    PurchaseTransactionId = 1,
                    UserId = 11111,
                    CustomerId = 11111,
                    VehicleId = 11111,
                    SalesPrice = 11111,
                    PaymentTypeId = 1
                },
                new PurchaseTransaction()
                {
                    PurchaseTransactionId = 2,
                    UserId = 22222,
                    CustomerId = 22222,
                    VehicleId = 22222,
                    SalesPrice = 22222,
                    PaymentTypeId = 2
                },
                new PurchaseTransaction()
                {
                    PurchaseTransactionId = 3,
                    UserId = 33333,
                    CustomerId = 33333,
                    VehicleId = 33333,
                    SalesPrice = 33333,
                    PaymentTypeId = 3
                },
                new PurchaseTransaction()
                {
                    PurchaseTransactionId = 4,
                    UserId = 44444,
                    CustomerId = 44444,
                    VehicleId = 44444,
                    SalesPrice = 44444,
                    PaymentTypeId = 3
                }
            };
        }
    }
}
