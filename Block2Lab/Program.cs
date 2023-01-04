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


            Book book1 = new Book(65554, "Invisible Monsters", 2.55m, "CP", "good", 10);
            Book book2 = new Book(55525, "NightFall", 5.25m, "IA", "goodest", 20);

            Apparel shirt = new Apparel(54115, "pretty", 3.55m, "XL", ApparelType.TShirt);
            Apparel pants = new Apparel(8555, "ugly", 2.55m, "L" , ApparelType.Pants);

            Sticker noToday = new Sticker(45, "No Today", 0.50m, .5m, true);
            Sticker yesToday = new Sticker(25, "yes Today", 1.5m, .26m, false);

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
                //string goes here
                Console.WriteLine(product.SalePrice());

            };
        
            
            

        }
    }
}
