﻿using System;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {


        public ShoppingCartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public decimal GetTotal()
        {
            return Quantity * Product.Price;
        }
    }
}
