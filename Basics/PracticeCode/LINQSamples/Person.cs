using System;
using System.Collections.Generic;
using System.Text;

namespace LINQSamples
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Person(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}
