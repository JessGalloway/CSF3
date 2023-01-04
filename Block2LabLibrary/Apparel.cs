using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Block2LabLibrary
{
    public sealed class Apparel : Product
    {
        //fields
        private string _size;
        ApparelType _type;

        //props

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public ApparelType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        //ctors

        public Apparel(int Id, string Name, int Price, string size, ApparelType type) : base (Id, Name, Price)
        {
            Size = size;
            Type = type;
        }

        public Apparel() { }

        public Apparel(int id, string name, decimal price, string size, ApparelType shirt) : base(id, name, price)
        {
        }

        //methods

        public override string ToString()
        {
            return $"Size: {Size}\nType: {Type}";
        }

        public override decimal SalePrice()
        {
            return Price * .95m;
        }

    }
}
