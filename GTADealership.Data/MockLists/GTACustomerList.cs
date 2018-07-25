using GTADealership.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTADealership.Data.MockLists
{
    public class GTACustomerList
    {
        public static List<Customer> GTACustomers { get; set; }

        static GTACustomerList()
        {
            GTACustomers = new List<Customer>()
            {
                new Customer()
                {
                    CustomerId = 1,
                    FirstName = "Liz",
                    LastName = "Ditts",
                    Street1 = "447 Monument Terrace",
                    Street2 = "2482",
                    City = "Dallas",
                    StateId = "TX",
                    Zip = "75397",
                    Phone = "214-146-2241",
                    Email = "lditts0@patch.com"
                },
                new Customer()
                {
                    CustomerId = 2,
                    FirstName = "Rosie",
                    LastName = "Petrovsky",
                    Street1 = "7778 Dennis Center",
                    Street2 = "113",
                    City = "Phoenix",
                    StateId = "AZ",
                    Zip = "85030",
                    Phone = "602-146-5817",
                    Email = "rpetrovsky1@latimes.com"
                },
                new Customer()
                {
                    CustomerId = 3,
                    FirstName = "Adriana",
                    LastName = "Bremmell",
                    Street1 = "196 Maple Junction",
                    Street2 = "75",
                    City = "Ogden",
                    StateId = "UT",
                    Zip = "84409",
                    Phone = "801-625-4192",
                    Email = "abremmell2@netvibes.com"
                },
                new Customer()
                {
                    CustomerId = 4,
                    FirstName = "Polly",
                    LastName = "Sisley",
                    Street1 = "54875 Crowley Pass",
                    Street2 = "33771",
                    City = "Dallas",
                    StateId = "TX",
                    Zip = "75241",
                    Phone = "469-175-6975",
                    Email = "psisley3@shop-pro.jp"
                },
                new Customer()
                {
                    CustomerId = 5,
                    FirstName = "Aloin",
                    LastName = "Kabos",
                    Street1 = "64411 Morrow Trail",
                    Street2 = "746",
                    City = "Lancaster",
                    StateId = "CA",
                    Zip = "93584",
                    Phone = "661-896-6736",
                    Email = "akabos4@biglobe.ne.jp"
                },
                new Customer()
                {
                    CustomerId = 6,
                    FirstName = "Zacherie",
                    LastName = "Passy",
                    Street1 = "06 Nancy Lane",
                    Street2 = "196",
                    City = "Mesa",
                    StateId = "AZ",
                    Zip = "85210",
                    Phone = "928-709-7908",
                    Email = "zpassy5@usatoday.com"
                },
                new Customer()
                {
                    CustomerId = 7,
                    FirstName = "Salomi",
                    LastName = "Jancy",
                    Street1 = "94269 Debra Street",
                    Street2 = "21",
                    City = "Boise",
                    StateId = "ID",
                    Zip = "83757",
                    Phone = "208-511-6627",
                    Email = "sjancy6@washington.edu"
                },
                new Customer()
                {
                    CustomerId = 8,
                    FirstName = "Asia",
                    LastName = "Bristowe",
                    Street1 = "6 High Crossing Drive",
                    Street2 = "22253",
                    City = "Saint Louis",
                    StateId = "MO",
                    Zip = "63104",
                    Phone = "314-966-4943",
                    Email = "abristowe7@taobao.com"
                },
                new Customer()
                {
                    CustomerId = 9,
                    FirstName = "Fran",
                    LastName = "Duddy",
                    Street1 = "11294 Schiller Point",
                    Street2 = "15",
                    City = "Richmond",
                    StateId = "VA",
                    Zip = "23272",
                    Phone = "804-117-8517",
                    Email = "fduddy8@unicef.org"
                },
                new Customer()
                {
                    CustomerId = 10,
                    FirstName = "Violetta",
                    LastName = "Willett",
                    Street1 = "417 Mayer Trail",
                    Street2 = "678",
                    City = "Atlanta",
                    StateId = "GA",
                    Zip = "30323",
                    Phone = "678-269-2765",
                    Email = "vwillett9@vimeo.com"
                }
            };
        }
    }
}
