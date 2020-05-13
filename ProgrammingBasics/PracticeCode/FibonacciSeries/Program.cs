using System;


namespace FibonacciSeries
{

    class Program
    {
        static void PrintSeries(int length)
        {
            int a = 0;
            int b = 1;
            int c;

            Console.Write($"{a}{b}");

            for (int i = 2; i < length; i++)
            {
                c = a + b;

                Console.Write($"{c}");
                a = b;
                b = c;
            }
        }

        static void Factorial(int number)
        {
            int factorial = 1;

            

            for (int i = 1; i <=number; i++)
            {
                factorial = factorial*i;
            }

            Console.WriteLine($"{factorial}");
        }
        static void Main(string[] args)
        {
            //PrintSeries(10);
            double d = 4.0;


            double d2 = 4.0;
            double result = d + d2;

        
            

            Console.WriteLine(string.Format("{0:F3}", result));
            Console.ReadLine();
        }
    }
}
