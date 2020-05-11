using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 10;;
            double average = 20.0;
            char letter = 'c';
            string name = "Tshepiso";
            bool value = true;
            float quotient = 0.9f;

            Console.WriteLine($"{number} is an interger");
            Console.WriteLine($"{average} is a double");
            Console.WriteLine($"{letter} is a character");
            Console.WriteLine($"{name} is is a string");
            Console.WriteLine($"{value} is a boolean");
            Console.WriteLine($"{quotient} is a float");


            Console.ReadLine();

        }
    }
}
