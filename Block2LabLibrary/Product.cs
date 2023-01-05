using Block2Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2LabLibrary
{
    public abstract class Product : IInventoriables 
    {
        //Fields

        private int _id;
        private string _name;
        private decimal _price;
        private int _inStock;
        
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

        public int InStock
        {
            get { return _inStock; }
            set { _inStock = value; }

        }

        public int OrderQty { get; set; }

        //ctors

        public Product(int id, string name, decimal price, int inStock, int orderQty)
        {
            Id = id;
            Name = name;
            Price = price;
            InStock = inStock;
            OrderQty = orderQty;

        }

        public Product() { }

        //methods

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nPrice: {Price}";
            
        }


        public abstract decimal SalePrice();

        //has to be overriden by derived classes
        public abstract int GetOrderQty(); 
       



    }//end class
}//end namespace
