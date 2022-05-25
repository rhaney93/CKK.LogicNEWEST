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
        private static Product _Product1;
        private static Product _Product2;
        private static Product _Product3;

       Product[] list = { _Product1, _Product2, _Product3 };


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
            if (product == _Product1)
                return;

            else if (product == _Product2)
            {
                _Product2 = _Product1;
            }
            else if (product == _Product3)
            {
                _Product3 = _Product1;
            }

        public void RemoveStoreItem(int productNumber)
            {
                
            }
        public Product GetStoreItem(int productNumber)
            {

            }
        public Product FindStoreItemById(int Id)
            {
                return list[Id];
            }

        }
    }
}