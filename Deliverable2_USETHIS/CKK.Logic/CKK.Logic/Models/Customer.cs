using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer
    {
        private int _Id;
        private string _Name;
        private string _Address;

        
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int Id)
        {
            _Id = Id;
        }

        public string GetName()
        {
            return _Name;
        }

        public void SetName(string Name)
        {
            _Name = Name;
        }

        public string GetAddress()
        {
            return _Address;
        }

        public void SetAddress(string Address)
        {
            _Address = Address;
        }
    }
}
