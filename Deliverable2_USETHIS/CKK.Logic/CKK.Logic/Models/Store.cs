using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class Store
    {
        private int _Id;
        private string _Name;
        private Product _Product1;
        private Product _Product2;
        private Product _Product3;

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

        public void AddStoreItem(Product product)
        {
            _Product1 = product;
            _Product2 = product;
            _Product3 = product;
        }

        /*public void RemoveStoreItem(productNumber int)
        {
            
        }*/
        public Product GetStoreItem(int productNumber)
        {
            
        }
        public Product FindStoreItemById(int Id)
        {
            return _Id;
        }

    }
}
