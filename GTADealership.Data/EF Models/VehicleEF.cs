using GTADealership.Data.EF_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Models.Tables
{
    public class VehicleEF
    {
        [Key]
        public int VehicleId { get; set; }
        public string VIN { get; set; }
        public int Milage { get; set; }        
        public int VModel_Id { get; set; }
        public bool IsNew { get; set; }
        public int ColorId { get; set; }
        public int BodyStyleId { get; set; }
        public int TransId { get; set; }
        public int InteriorId { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal MSRP { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public bool IsFeatured { get; set; }
        public int VehicleStatusId { get; set; }

        [ForeignKey("VModel_Id")]
        public virtual VModelEF VModel { get; set; }
        [ForeignKey("ColorId")]
        public virtual ColorEF Color { get; set; }
        [ForeignKey("BodyStyleId")]
        public virtual BodyStyleEF BodyStyle { get; set; }
        [ForeignKey("TransId")]
        public virtual TransEF Trans { get; set; }
        [ForeignKey("InteriorId")]
        public virtual InteriorEF Interior { get; set; }
        [ForeignKey("VehicleStatusId")]
        public virtual VehicleStatusEF VehicleStatus { get; set; }
    }
}
