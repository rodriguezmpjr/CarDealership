using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
    }
}
