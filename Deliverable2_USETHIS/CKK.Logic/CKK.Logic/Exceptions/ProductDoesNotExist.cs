using System;
using CKK.Logic.Models;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Exceptions
{
    public class ProductDoesNotExistException : Exception 
    {
        public ProductDoesNotExistException(string msg) : base(msg)
        {

        }
    }
}


