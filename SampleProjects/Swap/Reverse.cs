using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    public class Reverse
    {
        public void GetText()
        {
            string inputText,outputText;

            Console.WriteLine("Enter the text to that will be reversed");
            inputText = Console.ReadLine();

            outputText = ReverseString(inputText);

            Console.WriteLine($"The text reversed::::{outputText}");
        }

        private string ReverseString(string inputText)
        {
            var characters = inputText.ToCharArray();
            var newString = string.Empty;

            for (int i = characters.Length; i > 0; i--)
            {
                newString += characters[i-1]; 
            }

            return newString;
        }
    }
}
