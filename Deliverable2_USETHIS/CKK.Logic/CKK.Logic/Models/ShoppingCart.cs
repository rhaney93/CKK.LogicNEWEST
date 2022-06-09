using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private ShoppingCartItem _Product1 = null;
        private ShoppingCartItem _Product2 = null;
        private ShoppingCartItem _Product3 = null;

        public ShoppingCart(Customer customer)
        {
            _customer = customer;
        }


        public int GetCustomerId()
        {
            return _customer.GetId(); 
        }
        public ShoppingCartItem GetProductById(int Id)
        {
            if (Id == _Product1.GetId())
            {
                return _Product1;
            }

            else if (Id == _Product2.GetId())
            {
                return _Product2;
            }

            else if (Id == _Product3.GetId())
            {
                return _Product3;
            }

            return null;
        }



        public ShoppingCartItem AddProduct(Product product)
        {
            return AddProduct(product, 1);
        }
        public ShoppingCartItem AddProduct(Product product, int quantity)
        {
            // Make sure quantity is a positive number and product exists
            if (quantity <= 0 || product == null) return null;
            
            // If item 1 exists and it's product matches the provided product, update the quantity
            // and return item 1
            if (_Product1 != null && _Product1.GetProduct() == product)
            { 
                _Product1.SetQuantity(_Product1.GetQuantity() + quantity);
                return _Product1;
            }
            // If item 2 exists and it's product matches the provided product, update the quantity
            // and return item 2
            else if (_Product2 != null && _Product2.GetProduct() == product)
            {
                _Product2.SetQuantity(_Product2.GetQuantity() + quantity);
                return _Product2;
            }
            // If item 3 exists and it's product matches the provided product, update the quantity
            // and return item 3
            else if (_Product3 != null && _Product3.GetProduct() == product)
            {
                _Product3.SetQuantity(_Product3.GetQuantity() + quantity);
                return _Product3;
            }
            // If the product is new (we've made it this far!) and item 1 isn't tracked, track it there
            // and return item 1
            else if (_Product1 == null)
            {
                _Product1 = new ShoppingCartItem(product, quantity);
                return _Product1;
            }
            // If item 2 isn't tracked, track it there and return item 2
            else if (_Product2 == null)
            {
                _Product2 = new ShoppingCartItem(product, quantity);
                return _Product2;
            }
            // If item 3 isn't tracked, track it there and return item 3
            else if (_Product3 == null)
            {
                _Product3 = new ShoppingCartItem(product, quantity);
                return _Product3;
            }

            // All items are full, return null (indicating no operation)
            return null;
        }
        public ShoppingCartItem RemoveProduct(Product product, int quantity)
        {
            if (quantity <= 0) return null;

            // If item 1 exists and it's product matches the provided product, update the quantity
            // and update item 1 if necessary
            if (_Product1 != null && _Product1.GetProduct() == product)
            {
                int nextQuantity = _Product1.GetQuantity() - quantity;
                if (nextQuantity <= 0)
                {
                    _Product1 = null;
                    return _Product1;
                }

                _Product1.SetQuantity(nextQuantity);
                return _Product1;
            }
            // If item 2 exists and it's product matches the provided product, update the quantity
            // and return item 2
            else if (_Product2 != null && _Product2.GetProduct() == product)
            {
                int nextQuantity = _Product2.GetQuantity() - quantity;
                if (nextQuantity <= 0)
                {
                    _Product2 = null;
                    return _Product2;
                }

                _Product2.SetQuantity(nextQuantity);
                return _Product2;
            }
            // If item 3 exists and it's product matches the provided product, update the quantity
            // and return item 3
            else if (_Product3 != null && _Product3.GetProduct() == product)
            {
                int nextQuantity = _Product3.GetQuantity() - quantity;
                if (nextQuantity <= 0)
                {
                    _Product3 = null;
                    return _Product3;
                }

                _Product3.SetQuantity(nextQuantity);
                return _Product3;
            }

            return null;
        }
        public decimal GetTotal()
        {
            // Coerce each item to it's total or a deafult of 0
            decimal item1Total = _Product1 == null ? 0 : _Product1.GetTotal();
            decimal item2Total = _Product2 == null ? 0 : _Product2.GetTotal();
            decimal item3Total = _Product3 == null ? 0 : _Product3.GetTotal();

            return item1Total + item2Total + item3Total;
        }
        public ShoppingCartItem GetProduct(int productNumber)
        {
            if (productNumber == 1)
            {
                return _Product1;
            }

            else if (productNumber == 2)
            {
                return _Product2;
            }

            else if (productNumber == 3)
            {
                return _Product3;
            }

            return null;
        }
    }
}
