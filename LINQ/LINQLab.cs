using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string MembershipType { get; set; }
        public DateTime SignedUp { get; set; }

        public Customer(int id, string firstName, string lastName, string phone, string email, string address,
            string city, string state, string zipcode, string country, string membershipType, DateTime signedUp)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Address = address;
            City = city;
            State = state;
            Zipcode = zipcode;
            Country = country;
            MembershipType = membershipType;
            SignedUp = signedUp;
        }

        public override string ToString()
        {
            return string.Format($"ID: {ID}\nName: {FirstName} {LastName}\nContact: ph - {Phone} email - {Email}\n" +
                $"{Address}, {City}, {State} {Zipcode} {Country}\nMembership: {MembershipType} since {SignedUp:d}");
        }
    }
    internal class LINQLab
    {

        static void Main(string[] args)
        {
            #region Customers
            Customer c1 = new Customer(1, "Bob", "Smithshire", "123-245-9960", "bobbieontheshire@gmail.com", "123 ABC Street", "Atlanta", "GA", "33045", "United States", "Standard", new DateTime(2019, 01, 05));
            Customer c2 = new Customer(2, "Callie", "Troop", "123-245-9960", "callie@aol.com", "123 ABC Street", "Montreal", "Quebec", "A1G5", "Canada", "Platinum", new DateTime(2015, 01, 25));
            Customer c3 = new Customer(3, "Lana", "Smith", "123-245-9960", "lanaSmith@outlook.com", "123 ABC Street", "Memphis", "TN", "34056", "United States", "Gold", new DateTime(2021, 04, 05));
            Customer c4 = new Customer(4, "Kyle", "Jones", "", "kyle@gmail.com", "123 ABC Street", "Nowhere", "KS", "33026", "United States", "Standard", new DateTime(2021, 11, 15));
            Customer c5 = new Customer(5, "Cora", "Zane", "123-245-9960", "czane@hotmail.com", "123 ABC Street", "Cincinnati", "OH", "33496", "United States", "Standard", new DateTime(2000, 03, 07));
            #endregion

            //Student Lab Sets
            List<Customer> customers = new List<Customer>()
            {
                c1, c2, c3, c4, c5
            };



           // #region Alphabetical


            //var alphabetical = customers.OrderBy(c => c.LastName);

            //foreach (var item in alphabetical)
            //{
            //    Console.WriteLine(item);
            //}

            //#endregion

            //#region Country
            //var listCountry = customers.Where(c => c.Country.ToLower() == "united states");

            //foreach (var item in listCountry)
            //{
            //    Console.WriteLine(item);

            //}
            //#endregion


            //#region Gmail
            
            //var listGoogle = customers.Where(c => c.Email.ToLower().Contains("gmail.com"));

            //foreach (var item in listGoogle)
            //{
            //    Console.WriteLine(item);
            //}

           // #endregion

            //#region 5yr
            //var longTimeCustomers = customers.Where(c => c.SignedUp < DateTime.Now.AddYears(-5));

            //foreach (var item in longTimeCustomers)
            //{
            //    Console.WriteLine(item);
            //}

            //#endregion

            //#region Phone

            //var custCPhone = customers.Where(c => c.Phone != "");

            //foreach (var item in custCPhone)
            //{
            //    Console.WriteLine(item);
            //}

            //#endregion


            //#region GoldPlat

            //var custGoldPlat = customers.Where(c => c.MembershipType.ToLower() == "gold" || c.MembershipType.ToLower() == "platinum");


            //foreach (var item in custGoldPlat)
            //{
            //    Console.WriteLine(item);
            //}

            //#endregion

            //#region Smith
            //var lastNameHasSmith = customers.Where(c => c.LastName.ToLower().Contains("smith"));

            //foreach (var item in lastNameHasSmith)
            //{
            //    Console.WriteLine(item);
            //}

            //#endregion

            //#region Sort Id


            //var customerID = customers.OrderBy(c => c.ID);

            //foreach (var item in customerID)
            //{
            //    Console.WriteLine(item);
            //}

            //#endregion

        }
    }
}
