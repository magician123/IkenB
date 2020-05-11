using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region Constructors
        public Person() 
        {

        }
        public Person(int id): 
            this()
        {
            Id = id;
        }

        public Person(int id, string name) 
            : this(id)
        {
        
            Name = name;  
        }
        #endregion

    }
}
