using System;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    [Serializable]
    public class Product : Entity
    {
        private decimal _price;

        
        //Doesn't the shit below this already work???
        //public decimal Price { get; set; }

        public decimal Price

        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException("Cannot be a negative number");
                }
            }


        }

        public Product(decimal price, string name)
        {
            this.Price = price;
            this.Name = name;
            this.Id = 0;
        }

    }
}
