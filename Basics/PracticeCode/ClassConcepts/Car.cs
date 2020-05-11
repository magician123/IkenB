using System;
using System.Collections.Generic;
using System.Text;

namespace ClassConcepts
{
    public class Car
    {
        private string color;

        public string Color { get => color; set => color = value; }

        public Car(string color)
        {
            this.color = color;
        }
    }
}
