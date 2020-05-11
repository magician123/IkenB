using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTriangle
{
    public class TriangleBuilder
    {
        public void PrintTriangle()
        {
            int rows;
            bool binaryValue = true;

            rows = GetNumberOfRows();

            for (int i = 1; i < rows + 1; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (binaryValue)
                    {
                        Console.Write("1");
                        binaryValue = false;
                    }
                    else
                    {
                        Console.Write("0");
                        binaryValue = true;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public int GetNumberOfRows()
        {
            int rows;

            Console.WriteLine("Enter number of Rows you want to see");
            rows = int.Parse(Console.ReadLine());

            return rows;
        }

    }
}

