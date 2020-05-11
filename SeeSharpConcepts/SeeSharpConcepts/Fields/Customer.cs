using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> Orders { get; set; }

        public Customer(int id)
        {
            Id = id;

        }

        public Customer(int id, string name)
            :this(id)
        {
            Name = name;
        }
    }

    public class Order
    {

    }
}
