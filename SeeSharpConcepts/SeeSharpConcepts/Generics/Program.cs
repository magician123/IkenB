using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    static class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool AreEqual<T>(T firstNumber, T secondNumber) where T : IComparable<T>
        {
            return firstNumber.CompareTo(secondNumber) == 0;
        }
    }
}
