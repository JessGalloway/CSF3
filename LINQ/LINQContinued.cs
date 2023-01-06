using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Product 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public int Qty { get; set; }

        public decimal Price { get; set; }

        public string Status { get; set; }

        public string SupplierName { get; set; }

        public string SupplierCountry { get; set; }

        public Product(int id, string name, string category, int qty, decimal price, string status, string supplierName, string supplierCountry)
        {
            Id = id;
            Name = name;
            Category = category;
            Qty = qty;
            Price = price;
            Status = status;
            SupplierName = supplierName;
            SupplierCountry = supplierCountry;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nCategory: {Category}\nQty: {Qty}\nPrice: {Price}\nStatus: {Status}\nSupplierName: {SupplierName}\nSupplierCountry: {SupplierCountry}";
        }       

    }
    
    internal class LINQContinued
    {

        static void Main(string[] args)
        {

            #region Products
            Product p1 = new Product(1, "Chef Cart", "Kitchen", 5, 37.99m, "In Stock", "Chefs Friend", "Germany");
            Product p2 = new Product(2, "Craft Maple Cheddar", "Dairy", 35, 4.99m, "In Stock", "Blue Dairy", "Switzerland");
            Product p3 = new Product(3, "Cotton Candy Milk", "Dairy", 10, 6.99m, "Discontinued", "Shatto", "United States");
            Product p4 = new Product(4, "Organic Apples", "Produce", 60, 0.99m, "In Stock", "Macks Apples", "Germany");
            Product p5 = new Product(5, "Ground Bison", "Meat", 0, 10.99m, "Out of Stock", "Bills Bisons", "United States");
            #endregion

            var products = new List<Product>() { p1, p2, p3, p4, p5 };

            //1. Display all products with a price between $10 and $40

            //Method Syntax

            var prodsBetwn10And40 = products.Where(p => p.Price >= 10 && p.Price <= 40);

            foreach (var item in prodsBetwn10And40)
            {
                
                Console.WriteLine(item);
                
            }

            // Return all products in the Dairy category, sorted alphabetically by name

            //Method Syntax

            //Method chaining in C#
            var diaryProducts = products.Where(p => p.Category.ToLower() == "dairy").OrderBy(p => p.Name);

            foreach (var item in diaryProducts)
            {
                
                Console.WriteLine(item);
                
            }

            // Return a list of Products supplied by German companies that is sorted by price highest to lowest

            //Method Syntax

            var germanProducts = products.Where(p => p.SupplierCountry.ToLower() == "germany").OrderByDescending(p => p.Price);

            foreach (var item in germanProducts)
            {
                
                Console.WriteLine(item);
                
            }

            // Return a list of Products 'Chef' in the name sorted alphabetically, only return name and price

            //Method Syntax

            var chefProducts = products.Where(p => p.Name.ToLower().Contains("chef")).OrderBy(p => p.Name)
                .Select(p => new { Name = p.Name, Price = p.Price });

            foreach (var item in chefProducts)
            {
                
                Console.WriteLine($"{item.Name} - {item.Price:c}");
                
            }

            //List the 2 most expensive products

            var expensiveProducts = products.OrderByDescending(p => p.Price).Take(2);

            foreach (var item in expensiveProducts)
            {
                Console.WriteLine("\n=============\n" + item);
            }
            


            
        }//End Main()


    }//end class
}//end namespace
