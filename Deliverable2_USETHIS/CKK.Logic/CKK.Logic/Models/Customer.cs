using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Customer : Entity
    {
        //Do i not need these because they're inherited from Entity now? see UML

        //public int Id { get; set; }
        //public string Name { get; set; }
        public string Address { get; set; }

    }
}
