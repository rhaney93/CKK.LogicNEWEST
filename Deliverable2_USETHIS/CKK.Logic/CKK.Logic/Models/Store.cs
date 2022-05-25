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
           
            if (_Product1 == null) 
            {
                _Product1 = product;
            }
            
            else if (_Product2 == null)
            {
                _Product2 = product;
            }

            else if (_Product3 == null)
            {
                _Product3 = product;
            }
        }

        public void RemoveStoreItem(int productNumber)
        {
            if (productNumber == 1 && _Product1 != null) 
            {
                _Product1 = null;
            }

            else if (productNumber == 2 && _Product2 != null)
            {
                _Product2 = null;
            }

            else if (productNumber == 3 && _Product3 != null)
            {
                _Product3 = null;
            }
        }

        public Product GetStoreItem(int productNumber)
        {
            if (productNumber == 1) 
            { 
                return _Product1; 
            }

            else if (productNumber == 2) 
            { 
                return _Product2; 
            }

            else if (productNumber == 3) 
            { 
                return _Product3; 
            }

            return null;
        }
        public Product FindStoreItemById(int Id)
        {
            if (Id == _Product1.GetId()) 
            { 
                return _Product1; 
            }

            else if (Id == _Product2.GetId()) 
            { 
                return _Product2; 
            }

            else if (Id == _Product3.GetId()) 
            { 
                return _Product3; 
            }

            return null;
        }

        
    }
}