using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            shapes.Add(new Triangle());
            shapes.Add(new Circle());
            shapes.Add(new Square());

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadLine();
        }
    }
}
