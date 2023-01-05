using Block2Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Block2LabLibrary
{
    public sealed class Book : Product, IInventoriables
    {
        //fields
        
        private string _author;
        private string _genre;
        private int _nbrPages;
       

        //props

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int NbrPages
        {
            get { return _nbrPages; }
            set { _nbrPages = value; }
        }

      


        //ctors

        

        public Book(int Id, string Name, decimal price, string author, string genre, int nbrPages, int inStock, int orderQty) : base ( Id, Name, price, inStock, orderQty)
        {
            Author = author;
            Genre = genre;
            NbrPages = nbrPages;
            OrderQty = orderQty;
          
        }


        public Book() { }

        //methods

        public override int GetOrderQty()
        {
            int Qty = InStock - OrderQty;

            return Qty;
        }


        public override string ToString()
        {
            return $"Author: {Author}\nGenre: {Genre}\nNumber of Pages: {NbrPages}";
        }

        public override decimal SalePrice()
        {
            return Price * .85m;
        }



    }
}
