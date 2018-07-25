namespace GTADealership.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BodyStyleEFs",
                c => new
                    {
                        BodyStyleId = c.Int(nullable: false, identity: true),
                        BodyStyleName = c.String(),
                    })
                .PrimaryKey(t => t.BodyStyleId);
            
            CreateTable(
                "dbo.ColorEFs",
                c => new
                    {
                        ColorId = c.Int(nullable: false, identity: true),
                        ColorName = c.String(),
                    })
                .PrimaryKey(t => t.ColorId);
            
            CreateTable(
                "dbo.CustomerEFs",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Street1 = c.String(),
                        Street2 = c.String(),
                        City = c.String(),
                        StateId = c.String(maxLength: 128),
                        Zip = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.StateEFs", t => t.StateId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.StateEFs",
                c => new
                    {
                        StateId = c.String(nullable: false, maxLength: 128),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.StateId);
            
            CreateTable(
                "dbo.InteriorEFs",
                c => new
                    {
                        InteriorId = c.Int(nullable: false, identity: true),
                        InteriorName = c.String(),
                    })
                .PrimaryKey(t => t.InteriorId);
            
            CreateTable(
                "dbo.MakeEFs",
                c => new
                    {
                        MakeId = c.Int(nullable: false, identity: true),
                        MakeName = c.String(),
                    })
                .PrimaryKey(t => t.MakeId);
            
            CreateTable(
                "dbo.PaymentTypeEFs",
                c => new
                    {
                        PaymentTypeId = c.Int(nullable: false, identity: true),
                        PaymentName = c.String(),
                    })
                .PrimaryKey(t => t.PaymentTypeId);
            
            CreateTable(
                "dbo.PurchaseTransactionEFs",
                c => new
                    {
                        PurchaseTransactionId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        VehicleId = c.Int(nullable: false),
                        SalesPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseTransactionId)
                .ForeignKey("dbo.CustomerEFs", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.PaymentTypeEFs", t => t.PaymentTypeId, cascadeDelete: true)
                .ForeignKey("dbo.VehicleEFs", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.VehicleId)
                .Index(t => t.PaymentTypeId);
            
            CreateTable(
                "dbo.VehicleEFs",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        VIN = c.String(),
                        Milage = c.Int(nullable: false),
                        VModel_Id = c.Int(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        ColorId = c.Int(nullable: false),
                        BodyStyleId = c.Int(nullable: false),
                        TransId = c.Int(nullable: false),
                        InteriorId = c.Int(nullable: false),
                        SalesPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MSRP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        ImageName = c.String(),
                        IsFeatured = c.Boolean(nullable: false),
                        VehicleStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleId)
                .ForeignKey("dbo.BodyStyleEFs", t => t.BodyStyleId, cascadeDelete: true)
                .ForeignKey("dbo.ColorEFs", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.InteriorEFs", t => t.InteriorId, cascadeDelete: true)
                .ForeignKey("dbo.TransEFs", t => t.TransId, cascadeDelete: true)
                .ForeignKey("dbo.VehicleStatusEFs", t => t.VehicleStatusId, cascadeDelete: true)
                .ForeignKey("dbo.VModelEFs", t => t.VModel_Id, cascadeDelete: true)
                .Index(t => t.VModel_Id)
                .Index(t => t.ColorId)
                .Index(t => t.BodyStyleId)
                .Index(t => t.TransId)
                .Index(t => t.InteriorId)
                .Index(t => t.VehicleStatusId);
            
            CreateTable(
                "dbo.TransEFs",
                c => new
                    {
                        TransId = c.Int(nullable: false, identity: true),
                        TransName = c.String(),
                    })
                .PrimaryKey(t => t.TransId);
            
            CreateTable(
                "dbo.VehicleStatusEFs",
                c => new
                    {
                        VehicleStatusId = c.Int(nullable: false, identity: true),
                        VehicleStatusName = c.String(),
                    })
                .PrimaryKey(t => t.VehicleStatusId);
            
            CreateTable(
                "dbo.VModelEFs",
                c => new
                    {
                        VModelId = c.Int(nullable: false, identity: true),
                        ModelName = c.String(),
                        MakeId = c.Int(nullable: false),
                        SpecialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VModelId)
                .ForeignKey("dbo.MakeEFs", t => t.MakeId, cascadeDelete: true)
                .ForeignKey("dbo.SpecialEFs", t => t.SpecialId, cascadeDelete: true)
                .Index(t => t.MakeId)
                .Index(t => t.SpecialId);
            
            CreateTable(
                "dbo.SpecialEFs",
                c => new
                    {
                        SpeicialId = c.Int(nullable: false, identity: true),
                        SpecialTitle = c.String(),
                        SpecialDescription = c.String(),
                    })
                .PrimaryKey(t => t.SpeicialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseTransactionEFs", "VehicleId", "dbo.VehicleEFs");
            DropForeignKey("dbo.VehicleEFs", "VModel_Id", "dbo.VModelEFs");
            DropForeignKey("dbo.VModelEFs", "SpecialId", "dbo.SpecialEFs");
            DropForeignKey("dbo.VModelEFs", "MakeId", "dbo.MakeEFs");
            DropForeignKey("dbo.VehicleEFs", "VehicleStatusId", "dbo.VehicleStatusEFs");
            DropForeignKey("dbo.VehicleEFs", "TransId", "dbo.TransEFs");
            DropForeignKey("dbo.VehicleEFs", "InteriorId", "dbo.InteriorEFs");
            DropForeignKey("dbo.VehicleEFs", "ColorId", "dbo.ColorEFs");
            DropForeignKey("dbo.VehicleEFs", "BodyStyleId", "dbo.BodyStyleEFs");
            DropForeignKey("dbo.PurchaseTransactionEFs", "PaymentTypeId", "dbo.PaymentTypeEFs");
            DropForeignKey("dbo.PurchaseTransactionEFs", "CustomerId", "dbo.CustomerEFs");
            DropForeignKey("dbo.CustomerEFs", "StateId", "dbo.StateEFs");
            DropIndex("dbo.VModelEFs", new[] { "SpecialId" });
            DropIndex("dbo.VModelEFs", new[] { "MakeId" });
            DropIndex("dbo.VehicleEFs", new[] { "VehicleStatusId" });
            DropIndex("dbo.VehicleEFs", new[] { "InteriorId" });
            DropIndex("dbo.VehicleEFs", new[] { "TransId" });
            DropIndex("dbo.VehicleEFs", new[] { "BodyStyleId" });
            DropIndex("dbo.VehicleEFs", new[] { "ColorId" });
            DropIndex("dbo.VehicleEFs", new[] { "VModel_Id" });
            DropIndex("dbo.PurchaseTransactionEFs", new[] { "PaymentTypeId" });
            DropIndex("dbo.PurchaseTransactionEFs", new[] { "VehicleId" });
            DropIndex("dbo.PurchaseTransactionEFs", new[] { "CustomerId" });
            DropIndex("dbo.CustomerEFs", new[] { "StateId" });
            DropTable("dbo.SpecialEFs");
            DropTable("dbo.VModelEFs");
            DropTable("dbo.VehicleStatusEFs");
            DropTable("dbo.TransEFs");
            DropTable("dbo.VehicleEFs");
            DropTable("dbo.PurchaseTransactionEFs");
            DropTable("dbo.PaymentTypeEFs");
            DropTable("dbo.MakeEFs");
            DropTable("dbo.InteriorEFs");
            DropTable("dbo.StateEFs");
            DropTable("dbo.CustomerEFs");
            DropTable("dbo.ColorEFs");
            DropTable("dbo.BodyStyleEFs");
        }
    }
}
