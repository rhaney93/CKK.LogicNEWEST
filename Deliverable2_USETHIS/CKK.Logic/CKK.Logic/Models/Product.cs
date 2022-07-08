using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {

        //Same question as in Customer
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
