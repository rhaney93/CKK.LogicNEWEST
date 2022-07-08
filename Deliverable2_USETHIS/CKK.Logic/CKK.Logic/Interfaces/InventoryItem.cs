using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {
        public class Product
        {
            private Product _product;
            private int _quantity;


            public int Quantity 
            { 
                get { return _quantity; } 
                set { _quantity = value; }
            }

            public Product _Product 
            {
                get { return _product; } 
                set { _product = value; }
            }
        }      
    }
}
