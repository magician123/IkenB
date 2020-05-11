using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "my name is Tshepiso";
            string[] classMates = {"Thabo", "Mike", "Elias", "David","Sam","Ingrid","Thando","Bridget","Benny","Sizwe" };
            int[] numbers = { 5,7,9,5,8,34,56,23,43,67,8,90,12,34,21,56,90,56,43,23,32,56,78,90,4,3,100,1,3,55,78};

            var getNames = from name in classMates
                           where name.EndsWith("e")
                           orderby name descending
                           select name;

            Console.WriteLine(string.Join(",", getNames));
            Console.ReadLine();
        }
    }
}
