using System;
using System.Collections.Generic;
using System.Linq;

namespace TitleCapitalization
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string requestedTitle = Program.ConvertTitle("adada");

            return;
        }

        public static string ConvertTitle(string title)
        {
            string firstWord = title.Split(' ').FirstOrDefault()[0].ToString().ToUpper(); 
            string lastWord = title.Split(' ').LastOrDefault()[0].ToString().ToUpper();
            List<string> lowerCaseWords = new List<string>()
            {
                "the",
                "to",
                "at",
                "in",
                "with",
                "and",
                "but",
                "or"
            };

            string middleString = title.Replace(firstWord,"") + title.Replace(lastWord,"");

            foreach (var word in middleString)
            {
                if(lowerCaseWords.Contains(word.ToString()))
                {
                    word.ToString().ToLower(); 
                }
            }


            return string.Concat(firstWord, middleString, lastWord);
        }


    }
}
