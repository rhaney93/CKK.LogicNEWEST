using System;

namespace CKK.Logic.Exceptions
{
    [Serializable]
    public class InventoryItemStockTooLowException : Exception 
    {
        public InventoryItemStockTooLowException(string message): base(message) { }
    }
}
