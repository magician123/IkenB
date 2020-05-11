using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    class Program
    {
        private static float[] array = { 5.8f, 2.6f, 9.0f, 3.4f, 7.1f };
        static void Main(string[] args)
        {
            Console.WriteLine("Array Before reverse");
            PrintArray(array);

            Reverse(array, array.Length);

            Console.WriteLine("Array After reverse");
            PrintArray(array);

            Console.ReadKey();

        }
        public static void Reverse(float[] passedArray, int numberOfElements)
        {
            int i = 0;
            int j = 0;

            float[] newArray = new float[numberOfElements];


            //Assign elements of passedArray from last to first element to newArray        
            for (i = 0, j = passedArray.Length - 1; i < passedArray.Length; i++)
            {
                newArray[i] = passedArray[j--];
            }

            CopyArray(newArray);

        }

        private static void CopyArray(float[] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                array[i] = newArray[i];
            }
        }

        private static void PrintArray(float[] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
    }

}
