using Block2LabLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //create two instances for each type of product(i.e 2 for each child class)
            //Create a typed list and add all 6 objects to collection
            //interate through the typed list and print out each products info plus their sale price


            Book book1 = new Book(65554, "Invisible Monsters", 2.55m, "CP", "good", 10, 30, 3);
            Book book2 = new Book(55525, "NightFall", 5.25m, "IA", "goodest", 20, 30, 3);

            Apparel shirt = new Apparel(54115, "pretty", 3.55m, "XL", ApparelType.TShirt, 30, 3);
            Apparel pants = new Apparel(8555, "ugly", 2.55m, "L" , ApparelType.Pants, 30, 3);

            Sticker noToday = new Sticker(45, "No Today", 0.50m, .5m, true, 30, 2);
            Sticker yesToday = new Sticker(25, "yes Today", 1.5m, .26m, false, 30, 2);

            List<Product> products = new List<Product>()
            {

                book1,
                book2,
                shirt,
                pants,
                noToday,
                yesToday

            };

            foreach (Product product in products)
            {
                //string goes here with names of prducts and their sale price
                Console.WriteLine($"The sale price of 6{product.Name} is {product.SalePrice():c}");
                

            };
            Console.WriteLine("\n\n\n");
            foreach (Product product in products) 
            {

                Console.WriteLine($"Iventory list:\n{product.Name} " +
                    $"\nPoduct Id: {product.Id}\n" +
                    $"Product price: {product.Price}\n" +
                    $"Number to order: {product.GetOrderQty()}");

            }

            
            
            
            

        }
    }
}
