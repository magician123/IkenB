using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    public class Fibonacci
    {
        public void GetElementNumber()
        {
            int elementNumber;

            Console.WriteLine("Enter the number of Fibonacci elements you want to see");
            elementNumber = int.Parse(Console.ReadLine());

            CalculateFibonacci(elementNumber);
        }

        private void CalculateFibonacci(int elementNumber)
        {
            int initialValue = 0;
            int secondValue = 1;
            int fibonacciValue = 0;

            List<int> fibonacciSeries = new List<int>();

            for (int i = 0; i < elementNumber; i++)
            {
                fibonacciValue = initialValue + secondValue;
                initialValue = secondValue;
                secondValue = fibonacciValue;
                

                fibonacciSeries.Add(fibonacciValue);
            }

            DisplayResults(fibonacciSeries);
        }

        private void DisplayResults(List<int> fibonacciSeries)
        {
            for (int i = 0; i < fibonacciSeries.Count; i++)
            {
                Console.Write($"{fibonacciSeries[i]} , ");
            }
        }
    }
}
