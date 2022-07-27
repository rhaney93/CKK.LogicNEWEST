using System;

namespace CKK.Logic.Exceptions
{
    public class InventoryItemStockTooLowException : Exception 
    {
        public InventoryItemStockTooLowException(string message): base(message) { }
    }
}
