using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            EqualNumberChecker(2, 4);

            Console.ReadLine();
        }

        static bool EqualNumberChecker(int firstNumber, int secondNumber)
        {
            return (firstNumber == secondNumber ? true : false);
        }
    }
}
