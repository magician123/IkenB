using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Tishetjo","John","Sipho", "Ben", "Bob", "Bright", "Faith", "Tim", "Isaac"};

            List<string> lessThanFiveChars = new List<string>();

            foreach (var name in names)
            {
                if (name.Length < 5)
                    lessThanFiveChars.Add(name);
            }

            for (int i = 0; i < lessThanFiveChars.Count; i++)
            {
                Console.WriteLine($"{lessThanFiveChars[i]}");
            }

            Console.ReadLine();
        }
    }
}
