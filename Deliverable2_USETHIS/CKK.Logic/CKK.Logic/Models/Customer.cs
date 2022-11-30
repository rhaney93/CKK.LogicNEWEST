﻿using System;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    [Serializable]
    public class Customer : Entity
    {
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public int ShoppingCartId { get; set; }

    }
}
