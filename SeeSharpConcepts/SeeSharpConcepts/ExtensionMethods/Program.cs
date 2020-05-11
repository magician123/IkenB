using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 3, 5, 6, 7, 8, 9, 200, 34, 5, 7 };

            string text = "This is the extention method demo";

            
        }

        public static string SwapText(this string text)
        {
            string newText = string.Empty;

            for (int i = text.Length; i > 0; i--)
            {
                newText += text[i];
            }

            return newText;
        }
    }

}
