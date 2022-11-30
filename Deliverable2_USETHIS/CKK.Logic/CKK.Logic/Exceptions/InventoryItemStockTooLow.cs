using System;

namespace CKK.Logic.Exceptions
{
    [Serializable]
    public class InventoryItemStockTooLowException : Exception 
    {
        public InventoryItemStockTooLowException(): base("Stock too low") { }
    }
}
