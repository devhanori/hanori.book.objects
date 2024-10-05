using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Customer
    {
        private string Name { get; set; }
        private string Id { get; set; }

        public Customer(string name, string id)
        {
            this.Name = name;
            this.Id = id; 
        }
    }
}
