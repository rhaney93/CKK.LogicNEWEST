using System;
using CKK.Logic.Models;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Exceptions
{
    public class InventoryItemStockTooLowException : Exception 
    {
        public InventoryItemStockTooLowException(string msg) : base(msg)
        {

        }
    }
}
