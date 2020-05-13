using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurrence
{
    public class CharOccurrence
    {
        public void GetText()
        {
            string text;
            Console.WriteLine("Enter any random text");
            text = Console.ReadLine();

            var keyValuePair = CheckCharacterOccurrence(text);

            DisplayResults(keyValuePair);
        }

        private void DisplayResults(Dictionary<char, int> keyValuePair)
        {
            foreach (var character in keyValuePair)
            {
                Console.WriteLine($"{character.Key} :: {character.Value}");
            }
        }

        private Dictionary<char, int> CheckCharacterOccurrence(string text)
        {
            Dictionary<char, int> charCounter = new Dictionary<char, int>();
            var charArray = text.Replace(" ","").ToArray();
            int counter;

            foreach (var character in charArray)
            {
                counter = 1;

                if (charCounter.ContainsKey(character))
                {
                    charCounter[character] += counter; 
                }
                else
                {
                    charCounter.Add(character, counter);
                }
            }

            return charCounter;
        }
    }
}
