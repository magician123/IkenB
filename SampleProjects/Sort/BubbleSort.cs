using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class BubbleSort
    {
        public void GetData()
        {
            int arraySize;
            

            Console.WriteLine("Input the size of the array");
            arraySize = int.Parse(Console.ReadLine());

            int []array = new int[arraySize];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Input number {i + 1}");
                array[i] = int.Parse(Console.ReadLine());
            }
            

           var sortedArray = SortNumbers(array);

            DisplayResults(sortedArray);

        }

        private void DisplayResults(int[] sortedArray)
        {
            foreach (var number in sortedArray)
            {
                Console.Write($"{number} ");
            }
        }

        private int[] SortNumbers(int[] array)
        {
            int temp = 0;

             for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1 ; j++)
                {
                  
                    if( array[j] > array[j+1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }

            }

            return array;
        }
    }
}
