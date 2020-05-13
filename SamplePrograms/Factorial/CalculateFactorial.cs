using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class CalculateFactorial
    {
        public void PrintFactorial()
        {
            int number;
            int factorial;

            Console.WriteLine("Enter and interger");
            number = int.Parse(Console.ReadLine());

            factorial = Compute(number);

            Console.WriteLine($"The factorial of {number} is {factorial}");
        }

        public int Compute(int number)
        {
            int factorial = number;

            for (int i = 1; i < number; i++)
            {
                factorial = factorial * (number - i );
            }

            return factorial;
        }
    }
}
