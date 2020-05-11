using System;

namespace EvenNumber
{
    class Program
    {
        public static string EvalauateNumber(int number)
        {
            if (IsEven(number))
                return "The number is Even";
            else
                return "The number is Odd";
        }

        public static bool IsEven(int number)
        {
            bool even = (number % 2 == 0) ? true : false;

            return even;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer value");
            int enterNumber = int.Parse(Console.ReadLine());
            string results = Program.EvalauateNumber(enterNumber);

            Console.WriteLine($"{results}");

            Console.ReadLine();
        }
    }
}
