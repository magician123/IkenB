using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LINQSamples
{
   static class  Program
    {
        static void LinqBasics()
        {
            string sentence = "This is a long string";
            string[] catNames = { "Tshepiso", "Nnoi", "Michael", "Maria", "Ike", "Magician", "Timer", "Great" };
            int[] numbers = { 4, 5, 6, 7, 8, 9, 0, 90, 9, 97, 76, 5, 5, 4, 3, 2, 2, 2, 1, 1, 11, 11, 2223, 4 };

            var getNumbers = from number in numbers
                             where number > 40
                             select number;

            var Tnames = from name in catNames
                         where name.StartsWith('T')
                         select name;

            var catsWithA = from cat in catNames
                            where cat.Contains("a")
                            select cat;

            //Console.WriteLine(string.Join(",", getNumbers));

            // Console.WriteLine(string.Join("\n", Tnames));

            Console.WriteLine(string.Join("\n", catsWithA));
        }

        static void LinqOnObjects()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Tshepiso",35,Gender.Male),
                new Person("Lethabo",35,Gender.Female),
                new Person("Sipho",12,Gender.Male),
                new Person("Simon",78,Gender.Male),
                new Person("Nomsa",56,Gender.Female),
                new Person("Given",50,Gender.Male),
                new Person("Doris",67,Gender.Female),
                new Person("Daniel",45,Gender.Male)

            };


            var fiveCharpeople = from p in people
                                 where (p.Name.Length == 5)
                                 select p;

            foreach (var person in fiveCharpeople)
            {
                Console.WriteLine(string.Join("\n",person.Name));
            }
        }
        
        static void Main(string[] args)
        {

            // int[] array = { 23, 4, 5 };

            //Console.WriteLine($"{array.Add()}");

            Point point = new Point(20,30);

            

            Console.ReadLine();
        }

        static int Add(this int []array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
