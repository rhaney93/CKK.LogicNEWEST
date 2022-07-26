using System;
using CKK.Logic.Models;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Exceptions
{
    public class InvalidIdException : Exception { }
    public class InventoryItemStockTooLowException : Exception { }
    public class ProductDoesNotExistException : Exception { }

}

