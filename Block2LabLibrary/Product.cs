using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2LabLibrary
{
    public abstract class Product
    {
        //Fields

        private int _id;
        private string _name;
        private decimal _price;

        //props

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        //ctors

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Product() { }

        //methods

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nPrice: {Price}";
            
        }


        public abstract decimal SalePrice();

        



    }//end class
}//end namespace
