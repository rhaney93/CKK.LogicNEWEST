using System;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        public decimal Price
        {
            get { return Price; }
            set
            {
                Price = value;
                if (value > 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }


        }

    }
}
