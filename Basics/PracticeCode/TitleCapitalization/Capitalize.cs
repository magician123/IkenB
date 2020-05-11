using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TitleCapitalization
{
    internal class Capitalize
    {
        internal string TitleCase(string sentence)
        {
            string []newSenence = sentence.Split(' ');//1. Split this string
              //2. Get the first word
            newSenence[0]= CapitalizeWord(newSenence[0]);//3. capitalize first word(firstWord)
            newSenence[newSenence.Length] = CapitalizeWord(newSenence[newSenence.Length]);//capitalize last word
           // GetRemainingWords(newSenence);
                
            
            //Get the remaining words in the middle of the word

            //check if the exist in a pre-defined list of words

            //capitalize them

            // Lowercase any word that does not exit
            return "";
        }

       // private string[] GetRemainingWords(string[] newSenence)
       // {
       // //    string.Join();
       // }

        internal string CapitalizeWord(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}
