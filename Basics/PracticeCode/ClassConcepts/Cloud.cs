using System;
using System.Collections.Generic;
using System.Text;

namespace ClassConcepts
{
    public class Cloud
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public void Grow()
        {
            Console.WriteLine("The cloud has grown a bit");
        }

        public void Shrink()
        {
            Console.WriteLine("The cloud shrunk a bit");
        }
    }
}
