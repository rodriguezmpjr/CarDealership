using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTAPaymentTypeList
    {
        public static List<PaymentType> GTAPaymentTypes { get; set; }

        static GTAPaymentTypeList()
        {
            GTAPaymentTypes = new List<PaymentType>()
            {
                new PaymentType()
                {
                    PaymentTypeId = 1,
                    PaymentName = "Cash"
                },
                new PaymentType()
                {
                    PaymentTypeId = 2,
                    PaymentName = "BankFinance"
                },
                new PaymentType()
                {
                    PaymentTypeId = 3,
                    PaymentName = "DealerFinance"
                }
            };
        }
    }
}
