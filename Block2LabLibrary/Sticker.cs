using Block2Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2LabLibrary
{
    public sealed class Sticker : Product, IInventoriables
    {

        //fields
        private decimal _width;
        private bool _isBackgroundTransparent;

        //props

        public decimal Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public bool IsBackgroundTransparent
        {
            get { return _isBackgroundTransparent; }
            set { _isBackgroundTransparent = value; }
        }

        //ctors

        public Sticker(int Id, string Name, decimal Price, decimal width, bool isBackgroundTransparent, int inStock, int orderQty) : base(Id,Name,Price,inStock, orderQty)
        {
            Width = width;
            IsBackgroundTransparent = isBackgroundTransparent;
            OrderQty = orderQty;
        }

        public Sticker() { }

        //methods

        public override int GetOrderQty()
        {

            int Qty = InStock - OrderQty;
            return Qty;
        }


        public override string ToString()
        {
            return $"Width: {Width}\nIs Background Transparent: {IsBackgroundTransparent}";
        }

        public override decimal SalePrice()
        {
            return Price * .90m;
        }
    }
}
