using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GTADealership.Models.Tables;

namespace GTADealership.Data.EF_Models
{
    public class GTADealershipEntities : DbContext
    {
        public GTADealershipEntities() : base("GTADealershipDb")
        {
        }

        public DbSet<CustomerEF> Customers { get; set; }
        public DbSet<VehicleEF> Vheicles { get; set; }
        public DbSet<VModelEF> VModels { get; set; }
        public DbSet<BodyStyleEF> BodyStyles { get; set; }
        public DbSet<ColorEF> Colors { get; set; }
        public DbSet<InteriorEF> Interiors { get; set; }
        public DbSet<MakeEF> Makes { get; set; }
        public DbSet<PaymentTypeEF> PaymentTypes { get; set; }
        public DbSet<PurchaseTransactionEF> PurchaseTransactions { get; set; }
        public DbSet<SpecialEF> Specials { get; set; }
        public DbSet<StateEF> States { get; set; }
        public DbSet<TransEF> Trans { get; set; }
        public DbSet<VehicleStatusEF> VehicleStatuses { get; set; }

        internal void VModelEF()
        {
            throw new NotImplementedException();
        }
    }
}
