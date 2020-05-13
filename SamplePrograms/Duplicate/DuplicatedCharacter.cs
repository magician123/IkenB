using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate
{
    public class DuplicatedCharacter
    {
        public void GetInputText()
        {
            string text, noDuplicatesText;

            Console.WriteLine("Enter a random text ad I will remove duplicated characters on that string");
            text = Console.ReadLine();
            noDuplicatesText = GenerateNoDuplicatesString(text);

            Console.WriteLine($"new string with no duplicates ::{noDuplicatesText}");
        }

        private string GenerateNoDuplicatesString(string text)
        {
            string newString = string.Empty;
            var noDuplicates = RemoveDuplicates(text);

            foreach (var item in noDuplicates)
            {
                newString += item.Value; 
            }

            return newString;
        }

        private Dictionary<char,char> RemoveDuplicates(string text)
        {
            Dictionary<char, char> noDuplicates = new Dictionary<char, char>();

            var charArray = text.Replace(" ", "").ToArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (!noDuplicates.ContainsKey(charArray[i]))
                {
                    noDuplicates.Add(charArray[i], charArray[i]);

                }
            }

            return noDuplicates;
        }
    }
}
