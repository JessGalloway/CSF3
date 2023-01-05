using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Block2Interfaces
{
    public static class InventoryManager
    {
        public static string ProcessInventoryOrder(IInventoriables target) 
        {
            int inventory = target.GetOrderQty();

            int orderedQty = 30 - inventory;

            return $"Qty to oerder: {orderedQty} ";
            

        }


        
    }
}
