using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string VIN { get; set; }
        public string Year { get; set; }
        public int Mileage { get; set; }
        public string MakeName { get; set; }
        public string ModelName { get; set; }
        public bool IsNew { get; set; }
        public string ColorName { get; set; }
        public string BodyStyleName { get; set; }
        public string TransName { get; set; }
        public string InteriorName{ get; set; }
        [DataType(DataType.Currency)]
        public decimal SalesPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal MSRP { get; set; }
        //public string Description { get; set; }
        public string ImageName { get; set; }
        public bool IsFeatured { get; set; }
        public string StatusName { get; set; }

    }
}
