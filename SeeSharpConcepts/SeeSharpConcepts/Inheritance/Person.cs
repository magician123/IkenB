using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Speak()
        {
            Console.WriteLine("Person is speaking");
        }

        public void Walk()
        {
            Console.WriteLine("Person is walking");
        }
    }
}
