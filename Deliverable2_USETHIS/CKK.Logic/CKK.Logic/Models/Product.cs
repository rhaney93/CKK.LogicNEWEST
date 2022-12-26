using System;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    [Serializable]
    public class Product
    {
        private decimal _price;

        public int Id { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }

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
    }
}
