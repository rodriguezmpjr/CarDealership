namespace GTADealership.Data.Migrations
{
    using GTADealership.Data.EF_Models;
    using GTADealership.Models.Tables;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GTADealership.Data.EF_Models.GTADealershipEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GTADealership.Data.EF_Models.GTADealershipEntities context)
        {
            context.States.AddOrUpdate(s => s.StateId,
                new StateEF() { StateId = "GA", StateName = "Georgia" },
                new StateEF() { StateId = "TN", StateName = "Tennessee" },
                new StateEF() { StateId = "KY", StateName = "Kentucky" },
                new StateEF() { StateId = "MS", StateName = "Mississippi" },
                new StateEF() { StateId = "OH", StateName = "OH" }
            );

            context.SaveChanges();

            context.Customers.AddOrUpdate(c => c.CustomerId,
                new CustomerEF()
                {
                    CustomerId = 1,
                    FirstName = "Brandea",
                    LastName = "Syers",
                    Street1 = "950 Troy Point",
                    Street2 = "77",
                    City = "Lexington",
                    StateId = "KY",
                    Zip = "40581",
                    Phone = "859-874-5144",
                    Email = "bsyers0@elpais.com"
                }, new CustomerEF()
                {
                    CustomerId = 2,
                    FirstName = "Tannie",
                    LastName = "Point",
                    Street1 = "04103 Hanson Junction",
                    Street2 = "587",
                    City = "Atlanta",
                    StateId = "GA",
                    Zip = "30368",
                    Phone = "404-116-3002",
                    Email = "tpoint1@umich.edu"
                }, new CustomerEF()
                {
                    CustomerId = 3,
                    FirstName = "Jennilee",
                    LastName = "O'Griffin",
                    Street1 = "62496 School Road",
                    Street2 = "617",
                    City = "Lexington",
                    StateId = "KY",
                    Zip = "40591",
                    Phone = "859-478-5065",
                    Email = "jogriffin2@businessweek.com"
                }, new CustomerEF()
                {
                    CustomerId = 4,
                    FirstName = "Raven",
                    LastName = "Springtorpe",
                    Street1 = "7 Arapahoe Trail",
                    Street2 = "434",
                    City = "Atlanta",
                    StateId = "GA",
                    Zip = "30306",
                    Phone = "404-743-5167",
                    Email = "rspringtorpe3@canalblog.com"
                }, new CustomerEF()
                {
                    CustomerId = 5,
                    FirstName = "Hyacinth",
                    LastName = "Ellershaw",
                    Street1 = "09 Pennsylvania Crossing",
                    Street2 = "017",
                    City = "Cincinnati",
                    StateId = "OH",
                    Zip = "45228",
                    Phone = "513-114-9297",
                    Email = "hellershaw4@latimes.com"
                }, new CustomerEF()
                {
                    CustomerId = 6,
                    FirstName = "Michaella",
                    LastName = "Appleford",
                    Street1 = "040 American Ash Point",
                    Street2 = "36",
                    City = "Memphis",
                    StateId = "TN",
                    Zip = "38119",
                    Phone = "901-690-2346",
                    Email = "mappleford5@hhs.gov"
                }, new CustomerEF()
                {
                    CustomerId = 7,
                    FirstName = "Goldarina",
                    LastName = "Diment",
                    Street1 = "21020 Jana Court",
                    Street2 = "08",
                    City = "Knoxville",
                    StateId = "TN",
                    Zip = "37919",
                    Phone = "865-851-9206",
                    Email = "gdiment6@slashdot.org"
                }, new CustomerEF()
                {
                    CustomerId = 8,
                    FirstName = "Kinny",
                    LastName = "Ballam",
                    Street1 = "4 Monterey Point",
                    Street2 = "633",
                    City = "Cincinnati",
                    StateId = "OH",
                    Zip = "45223",
                    Phone = "513-139-2564",
                    Email = "kballam7@reddit.com"
                }, new CustomerEF()
                {
                    CustomerId = 9,
                    FirstName = "Henrietta",
                    LastName = "Tudbald",
                    Street1 = "10 Schiller Hill",
                    Street2 = "46",
                    City = "Atlanta",
                    StateId = "GA",
                    Zip = "31119",
                    Phone = "770-778-7931",
                    Email = "htudbald8@stanford.edu"
                }, new CustomerEF()
                {
                    CustomerId = 10,
                    FirstName = "Blakelee",
                    LastName = "Coward",
                    Street1 = "555 Ruskin Point",
                    Street2 = "31",
                    City = "Lexington",
                    StateId = "KY",
                    Zip = "40546",
                    Phone = "859-857-6699",
                    Email = "bcoward9@npr.org"
                }, new CustomerEF()
                {
                    CustomerId = 11,
                    FirstName = "Joline",
                    LastName = "Hullock",
                    Street1 = "3769 Kedzie Road",
                    Street2 = "63",
                    City = "Akron",
                    StateId = "OH",
                    Zip = "44310",
                    Phone = "330-386-4016",
                    Email = "jhullocka@blogtalkradio.com"
                }, new CustomerEF()
                {
                    CustomerId = 12,
                    FirstName = "Tailor",
                    LastName = "Edgworth",
                    Street1 = "3 Mesta Crossing",
                    Street2 = "5674",
                    City = "Lexington",
                    StateId = "KY",
                    Zip = "40510",
                    Phone = "859-897-8114",
                    Email = "tedgworthb@bloglovin.com"
                }, new CustomerEF()
                {
                    CustomerId = 13,
                    FirstName = "Shaughn",
                    LastName = "Maric",
                    Street1 = "9908 Northridge Road",
                    Street2 = "02",
                    City = "Macon",
                    StateId = "GA",
                    Zip = "31217",
                    Phone = "912-671-1464",
                    Email = "smaricc@pcworld.com"
                }, new CustomerEF()
                {
                    CustomerId = 14,
                    FirstName = "Tobie",
                    LastName = "Garrioch",
                    Street1 = "67 Elka Hill",
                    Street2 = "760",
                    City = "Columbus",
                    StateId = "OH",
                    Zip = "43220",
                    Phone = "614-346-1070",
                    Email = "tgarriochd@abc.net.au"
                }, new CustomerEF()
                {
                    CustomerId = 15,
                    FirstName = "Janette",
                    LastName = "Giercke",
                    Street1 = "076 Blue Bill Park Street",
                    Street2 = "0990",
                    City = "Columbus",
                    StateId = "GA",
                    Zip = "31998",
                    Phone = "706-450-7853",
                    Email = "jgierckee@yelp.com"
                }, new CustomerEF()
                {
                    CustomerId = 16,
                    FirstName = "Melinda",
                    LastName = "Peet",
                    Street1 = "6 Independence Pass",
                    Street2 = "0880",
                    City = "Cleveland",
                    StateId = "OH",
                    Zip = "44177",
                    Phone = "216-913-8333",
                    Email = "mpeetf@pcworld.com"
                }, new CustomerEF()
                {
                    CustomerId = 17,
                    FirstName = "Faina",
                    LastName = "Benois",
                    Street1 = "2123 Nova Crossing",
                    Street2 = "1",
                    City = "Lexington",
                    StateId = "KY",
                    Zip = "40505",
                    Phone = "859-664-5378",
                    Email = "fbenoisg@a8.net"
                }, new CustomerEF()
                {
                    CustomerId = 18,
                    FirstName = "Prescott",
                    LastName = "Mead",
                    Street1 = "30 Pine View Park",
                    Street2 = "8278",
                    City = "Cincinnati",
                    StateId = "OH",
                    Zip = "45264",
                    Phone = "513-501-6851",
                    Email = "pmeadh@infoseek.co.jp"
                }, new CustomerEF()
                {
                    CustomerId = 19,
                    FirstName = "Lauryn",
                    LastName = "Borman",
                    Street1 = "53 Pond Place",
                    Street2 = "6",
                    City = "Columbus",
                    StateId = "GA",
                    Zip = "31914",
                    Phone = "706-234-0893",
                    Email = "lbormani@miitbeian.gov.cn"
                }, new CustomerEF()
                {
                    CustomerId = 20,
                    FirstName = "Alverta",
                    LastName = "Creddon",
                    Street1 = "144 Hooker Road",
                    Street2 = "2",
                    City = "Canton",
                    StateId = "OH",
                    Zip = "44705",
                    Phone = "330-685-4602",
                    Email = "acreddonj@bizjournals.com"
                }, new CustomerEF()
                {
                    CustomerId = 21,
                    FirstName = "Griffith",
                    LastName = "Hince",
                    Street1 = "76 Springview Crossing",
                    Street2 = "8833",
                    City = "Toledo",
                    StateId = "OH",
                    Zip = "43615",
                    Phone = "419-540-0060",
                    Email = "ghincek@paginegialle.it"
                }, new CustomerEF()
                {
                    CustomerId = 22,
                    FirstName = "Eliza",
                    LastName = "Coverdale",
                    Street1 = "50890 Mosinee Place",
                    Street2 = "31867",
                    City = "Lexington",
                    StateId = "KY",
                    Zip = "40596",
                    Phone = "859-139-8079",
                    Email = "ecoverdalel@dion.ne.jp"
                }, new CustomerEF()
                {
                    CustomerId = 23,
                    FirstName = "Edmund",
                    LastName = "MacKessock",
                    Street1 = "01260 Mallory Avenue",
                    Street2 = "265",
                    City = "Cleveland",
                    StateId = "OH",
                    Zip = "44177",
                    Phone = "216-759-3618",
                    Email = "emackessockm@ucla.edu"
                }, new CustomerEF()
                {
                    CustomerId = 24,
                    FirstName = "Adrien",
                    LastName = "Locard",
                    Street1 = "7 Merrick Trail",
                    Street2 = "43",
                    City = "Dayton",
                    StateId = "OH",
                    Zip = "45426",
                    Phone = "937-135-9834",
                    Email = "alocardn@hostgator.com"
                }, new CustomerEF()
                {
                    CustomerId = 25,
                    FirstName = "Federico",
                    LastName = "Walmsley",
                    Street1 = "6945 Jackson Lane",
                    Street2 = "45992",
                    City = "Athens",
                    StateId = "GA",
                    Zip = "30605",
                    Phone = "706-147-3718",
                    Email = "fwalmsleyo@archive.org"
                }
                );



            context.PaymentTypes.AddOrUpdate(p => p.PaymentTypeId,
                new PaymentTypeEF() { PaymentTypeId = 1, PaymentName = "Cash" },
                new PaymentTypeEF() { PaymentTypeId = 2, PaymentName = "Bank Finance" },
                new PaymentTypeEF() { PaymentTypeId = 3, PaymentName = "Dealer Finance" }
                );

            context.SaveChanges();

            context.Trans.AddOrUpdate(t => t.TransId, 
                new TransEF() { TransId = 1, TransName = "Manual"},
                new TransEF() { TransId = 2, TransName = "Automatic" }
                );

            context.VehicleStatuses.AddOrUpdate(s => s.VehicleStatusId,
                new VehicleStatusEF() { VehicleStatusId = 1, VehicleStatusName = "Available" },
                new VehicleStatusEF() { VehicleStatusId = 2, VehicleStatusName = "Sale Pending" },
                new VehicleStatusEF() { VehicleStatusId = 3, VehicleStatusName = "Sold" }
                );

            context.BodyStyles.AddOrUpdate(b => b.BodyStyleId,
                new BodyStyleEF() { BodyStyleId = 1, BodyStyleName = "Sedan"},
                new BodyStyleEF() { BodyStyleId = 2, BodyStyleName = "Truck" },
                new BodyStyleEF() { BodyStyleId = 3, BodyStyleName = "SUV" }
                );

            context.Interiors.AddOrUpdate(i => i.InteriorId,
                new InteriorEF() { InteriorId = 1, InteriorName = "Leather"},
                new InteriorEF() { InteriorId = 2, InteriorName = "Cloth" },
                new InteriorEF() { InteriorId = 3, InteriorName = "Suede" }
                );

            context.Specials.AddOrUpdate(s => s.SpeicialId,
                new SpecialEF() { SpeicialId = 1 , SpecialTitle = "Factory Rebate", SpecialDescription = "$5000 Factory Rebate" },
                new SpecialEF() { SpeicialId = 2, SpecialTitle = "BOGO", SpecialDescription = "Buy One Get One" },
                new SpecialEF() { SpeicialId = 3, SpecialTitle = "$0 Down", SpecialDescription = "Zero down $199/month" }
                );

            context.Colors.AddOrUpdate(c => c.ColorId,
                new ColorEF() { ColorId = 1, ColorName = "Red"},
                new ColorEF() { ColorId = 2, ColorName = "Black" },
                new ColorEF() { ColorId = 3, ColorName = "Blue" }
                );

            context.Makes.AddOrUpdate(m => m.MakeId,
                new MakeEF() { MakeId = 1, MakeName = "Dodge"},
                new MakeEF() { MakeId = 2, MakeName = "Ford" },
                new MakeEF() { MakeId = 3, MakeName = "Nissan" },
                new MakeEF() { MakeId = 4, MakeName = "Buick" },
                new MakeEF() { MakeId = 5, MakeName = "Chevy" }
                );

            context.SaveChanges();

            context.VModels.AddOrUpdate(v => v.VModelId,
                new VModelEF() { VModelId = 1, ModelName = "Charger", MakeId = 1, SpecialId = 1 },
                new VModelEF() { VModelId = 2, ModelName = "Mustang", MakeId = 2, SpecialId = 2 },
                new VModelEF() { VModelId = 3, ModelName = "Armada", MakeId = 3 , SpecialId = 3 },
                new VModelEF() { VModelId = 4, ModelName = "Encore", MakeId = 4, SpecialId = 1 },
                new VModelEF() { VModelId = 5, ModelName = "Corvette", MakeId = 5, SpecialId = 2 }
                );

            context.SaveChanges();

            context.Vheicles.AddOrUpdate(v => v.VehicleId,
                new VehicleEF()
                {
                    VehicleId = 1,
                    VIN = "KMHHT6KD5CU522368",
                    Milage = 19,
                    VModel_Id = 2,
                    IsNew = true,
                    ColorId = 2,
                    BodyStyleId = 1,
                    TransId = 2,
                    InteriorId = 1,
                    SalesPrice = 26532,
                    MSRP = 55819,
                    Description = "2018",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 2,
                    VIN = "3N1CE2CPXFL405381",
                    Milage = 20271,
                    VModel_Id = 4,
                    IsNew = false,
                    ColorId = 2,
                    BodyStyleId = 1,
                    TransId = 2,
                    InteriorId = 3,
                    SalesPrice = 54635,
                    MSRP = 55271,
                    Description = "1995",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 3,
                    VIN = "2G4GN5EX4F9962220",
                    Milage = 33719,
                    VModel_Id = 1,
                    IsNew = false,
                    ColorId = 3,
                    BodyStyleId = 3,
                    TransId = 1,
                    InteriorId = 1,
                    SalesPrice = 15868,
                    MSRP = 26372,
                    Description = "2002",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 4,
                    VIN = "YV4902DZ4B2105320",
                    Milage = 29833,
                    VModel_Id = 3,
                    IsNew = false,
                    ColorId = 3,
                    BodyStyleId = 3,
                    TransId = 2,
                    InteriorId = 3,
                    SalesPrice = 37809,
                    MSRP = 40000,
                    Description = "1989",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 5,
                    VIN = "1G4GC5EG4AF791121",
                    Milage = 27470,
                    VModel_Id = 1,
                    IsNew = false,
                    ColorId = 1,
                    BodyStyleId = 2,
                    TransId = 2,
                    InteriorId = 3,
                    SalesPrice = 15612,
                    MSRP = 46767,
                    Description = "1986",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 6,
                    VIN = "WBALM5C57AE715719",
                    Milage = 10040,
                    VModel_Id = 2,
                    IsNew = false,
                    ColorId = 1,
                    BodyStyleId = 1,
                    TransId = 1,
                    InteriorId = 3,
                    SalesPrice = 47473,
                    MSRP = 48000,
                    Description = "2008",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 2
                }, new VehicleEF()
                {
                    VehicleId = 7,
                    VIN = "JTEBU4BF1DK423178",
                    Milage = 479,
                    VModel_Id = 4,
                    IsNew = true,
                    ColorId = 2,
                    BodyStyleId = 1,
                    TransId = 2,
                    InteriorId = 1,
                    SalesPrice = 41987,
                    MSRP = 43267,
                    Description = "2017",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 8,
                    VIN = "WDDHF2EB9CA192269",
                    Milage = 0,
                    VModel_Id = 5,
                    IsNew = true,
                    ColorId = 3,
                    BodyStyleId = 3,
                    TransId = 2,
                    InteriorId = 1,
                    SalesPrice = 44221,
                    MSRP = 48314,
                    Description = "2018",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 9,
                    VIN = "JHMFA3F24BS157277",
                    Milage = 21594,
                    VModel_Id = 5,
                    IsNew = false,
                    ColorId = 2,
                    BodyStyleId = 3,
                    TransId = 1,
                    InteriorId = 1,
                    SalesPrice = 56580,
                    MSRP = 57511,
                    Description = "2009",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 3
                }, new VehicleEF()
                {
                    VehicleId = 10,
                    VIN = "2G4WB55K211972132",
                    Milage = 0,
                    VModel_Id = 1,
                    IsNew = true,
                    ColorId = 1,
                    BodyStyleId = 1,
                    TransId = 2,
                    InteriorId = 3,
                    SalesPrice = 42516,
                    MSRP = 23993,
                    Description = "2018",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 11,
                    VIN = "JN1BY1AP2FM040278",
                    Milage = 23501,
                    VModel_Id = 2,
                    IsNew = false,
                    ColorId = 1,
                    BodyStyleId = 1,
                    TransId = 2,
                    InteriorId = 1,
                    SalesPrice = 14536,
                    MSRP = 22186,
                    Description = "2007",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 2
                }, new VehicleEF()
                {
                    VehicleId = 12,
                    VIN = "1G6AR5S39E0575447",
                    Milage = 30967,
                    VModel_Id = 2,
                    IsNew = false,
                    ColorId = 2,
                    BodyStyleId = 2,
                    TransId = 2,
                    InteriorId = 2,
                    SalesPrice = 44671,
                    MSRP = 58918,
                    Description = "1988",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 13,
                    VIN = "TRUTC28N931704444",
                    Milage = 49950,
                    VModel_Id = 3,
                    IsNew = true,
                    ColorId = 2,
                    BodyStyleId = 2,
                    TransId = 2,
                    InteriorId = 3,
                    SalesPrice = 38525,
                    MSRP = 8564,
                    Description = "2012",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 14,
                    VIN = "WA1CYBFE2AD498453",
                    Milage = 36288,
                    VModel_Id = 4,
                    IsNew = false,
                    ColorId = 1,
                    BodyStyleId = 2,
                    TransId = 1,
                    InteriorId = 3,
                    SalesPrice = 15732,
                    MSRP = 52486,
                    Description = "2009",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 15,
                    VIN = "2HNYD18275H633627",
                    Milage = 64,
                    VModel_Id = 4,
                    IsNew = true,
                    ColorId = 3,
                    BodyStyleId = 2,
                    TransId = 1,
                    InteriorId = 3,
                    SalesPrice = 6832,
                    MSRP = 32298,
                    Description = "2017",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 2
                }, new VehicleEF()
                {
                    VehicleId = 16,
                    VIN = "WAUKFAFL4BA260846",
                    Milage = 748,
                    VModel_Id = 1,
                    IsNew = true,
                    ColorId = 1,
                    BodyStyleId = 1,
                    TransId = 2,
                    InteriorId = 2,
                    SalesPrice = 37799,
                    MSRP = 38371,
                    Description = "2017",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 17,
                    VIN = "WAUAFAFL9EN684726",
                    Milage = 23471,
                    VModel_Id = 4,
                    IsNew = true,
                    ColorId = 3,
                    BodyStyleId = 2,
                    TransId = 2,
                    InteriorId = 3,
                    SalesPrice = 11624,
                    MSRP = 9146,
                    Description = "1993",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 18,
                    VIN = "WAUMGAFL1BA734161",
                    Milage = 21818,
                    VModel_Id = 2,
                    IsNew = true,
                    ColorId = 2,
                    BodyStyleId = 2,
                    TransId = 2,
                    InteriorId = 3,
                    SalesPrice = 45945,
                    MSRP = 21656,
                    Description = "2000",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 3
                }, new VehicleEF()
                {
                    VehicleId = 19,
                    VIN = "19UUA8F28DA430804",
                    Milage = 22681,
                    VModel_Id = 4,
                    IsNew = false,
                    ColorId = 1,
                    BodyStyleId = 1,
                    TransId = 1,
                    InteriorId = 3,
                    SalesPrice = 20251,
                    MSRP = 37789,
                    Description = "2002",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 3
                }, new VehicleEF()
                {
                    VehicleId = 20,
                    VIN = "1GTN2TEH8FZ494323",
                    Milage = 37999,
                    VModel_Id = 5,
                    IsNew = true,
                    ColorId = 2,
                    BodyStyleId = 1,
                    TransId = 2,
                    InteriorId = 1,
                    SalesPrice = 57581,
                    MSRP = 32660,
                    Description = "1992",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 21,
                    VIN = "2C3CCARGXFH828107",
                    Milage = 6077,
                    VModel_Id = 4,
                    IsNew = false,
                    ColorId = 1,
                    BodyStyleId = 2,
                    TransId = 2,
                    InteriorId = 3,
                    SalesPrice = 35860,
                    MSRP = 49273,
                    Description = "2008",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    VehicleStatusId = 1
                }, new VehicleEF()
                {
                    VehicleId = 22,
                    VIN = "1GKS1AE09BR961252",
                    Milage = 10778,
                    VModel_Id = 4,
                    IsNew = true,
                    ColorId = 3,
                    BodyStyleId = 1,
                    TransId = 2,
                    InteriorId = 1,
                    SalesPrice = 40719,
                    MSRP = 37971,
                    Description = "1994",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    VehicleStatusId = 3
                }, new VehicleEF()
                {
                    VehicleId = 23,
                    VIN = "SCBLC47J48C846400",
                    Milage = 21373,
                    VModel_Id = 3,
                    IsNew = false,
                    ColorId = 1,
                    BodyStyleId = 1,
                    TransId = 1,
                    InteriorId = 2,
                    SalesPrice = 19729,
                    MSRP = 49748,
                    Description = "2012",
                    ImageName = "Charger.jpg",
                    IsFeatured = true,
                    VehicleStatusId = 3
                }, new VehicleEF()
                {
                    VehicleId = 24,
                    VIN = "WBAAZ33413K155060",
                    Milage = 15157,
                    VModel_Id = 5,
                    IsNew = false,
                    ColorId = 3,
                    BodyStyleId = 1,
                    TransId = 1,
                    InteriorId = 2,
                    SalesPrice = 5712,
                    MSRP = 26597,
                    Description = "1996",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 3
                }, new VehicleEF()
                {
                    VehicleId = 25,
                    VIN = "WAUKC68DX1A210611",
                    Milage = 27836,
                    VModel_Id = 1,
                    IsNew = true,
                    ColorId = 3,
                    BodyStyleId = 1,
                    TransId = 1,
                    InteriorId = 2,
                    SalesPrice = 14076,
                    MSRP = 25752,
                    Description = "2011",
                    ImageName = "Charger.jpg",
                    IsFeatured = false,
                    VehicleStatusId = 1
                }
                );

        }
    }
}
