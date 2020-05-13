using System;

namespace ClassConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Red");

            Console.WriteLine($"The color is {car1.Color}");

            Console.ReadLine();
        }
    }
}
