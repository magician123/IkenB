using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public class ComputeStatistics
    {
        public void GetUserInput()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 4; i++)
            {

                Console.WriteLine($"Enter number {i + 1}");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            var sum = CalculateSum(numbers);
            var average = CalculateAverage(numbers);
            var smallest = FindSmallest(numbers);
            var biggest = FindBiggest(numbers);

            DisplayResults(sum, average, smallest, biggest);
        }

        private void DisplayResults(int sum, int average, int smallest, int biggest)
        {
            Console.WriteLine($"The sum of the numbers above is {sum}");
            Console.WriteLine($"The average of the numbers above is {average}");
            Console.WriteLine($"The smallest of the numbers above is {smallest}");
            Console.WriteLine($"The biggest of the numbers above is {biggest}");
        }

        private int FindBiggest(List<int> numbers)
        {
            int biggest = -999999999;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > biggest)
                {
                    biggest = numbers[i];
                }
            }

            return biggest;
        }

        private int FindSmallest(List<int> numbers)
        {
            int smallest = 999999999;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            return smallest;

        }

        private int CalculateAverage(List<int> numbers)
        {
            int sum = CalculateSum(numbers);

            return sum / numbers.Count;
        }

        private int CalculateSum(List<int> numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
