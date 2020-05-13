using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrone
{
    public class ComputePalindrome
    {
        public void ValidatePalindrome()
        {
            string givenWord, newWord;
            

            Console.WriteLine("Enter a word and see if it is a Palindrome or Not");
            givenWord = Console.ReadLine();
            newWord = GenerateNewWord(givenWord);

            if(IsPalindrome(givenWord,newWord))
            {
                Console.WriteLine("The text above is a Palindrome");
            }
            else
            {
                Console.WriteLine("The text above is not a Palindrome");
            }
        }

        public bool IsPalindrome(string givenWord, string generatedWord)
        {
            if (givenWord == generatedWord)
                return true;
            else
                return false;

        }
        public string GenerateNewWord(string word)
        {
            string reversedWord = string.Empty;
            char []splitedCharacters = word.ToCharArray();

            for (int i = splitedCharacters.Length; i > 0; i--)
            {
                reversedWord += splitedCharacters[i-1];
            }

            return reversedWord;
        }
    }
}
