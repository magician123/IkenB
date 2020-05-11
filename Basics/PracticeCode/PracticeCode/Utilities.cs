using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PracticeCode
{
    internal class Utilities
    {

        internal string ReverseOderOfWords(string text)
        {
            string reversedWords = string.Empty;
            var words = text.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedWords += words[i] + " ";
            }


            return reversedWords;
        }
        internal string PlindroneChecker(string text)
        {
            string newText = ReverseString(text);

            if (text == newText)
                return $"{text} is a Palindrone";
            else
                return $"{text} is not a Palindrone";

        }
        internal string ReverseString(string text)
        {
            var charArray = text.ToCharArray();

            for (int i = 0, j = text.Length - 1; i < j; i++, j--)
            {
                charArray[i] = text[j];
                charArray[j] = text[i];
            }

            return new string(charArray);
        }

        internal void CountOccurenceOfCharacter(string text)
        {
            //declare a dictionary to return
            Dictionary<char, int> characterCounter = new Dictionary<char, int>();
            //trim the string and split the string into char array
            var characters = text.Trim().ToArray();

            //loop through the the char array
            foreach (var character in characters)
            {
                if (!characterCounter.ContainsKey(character))
                //if it is the first time you see it, make it a key, and the value==1
                {
                    characterCounter.Add(character, 1);
                }

                else
                    //if it already exist in the dictionary, increment the value
                    characterCounter[character] += 1;
            }



            //return the dictionary
            DisplayResults(characterCounter);
        }

        private void DisplayResults(Dictionary<char, int> characterCounter)
        {
            foreach (var item in characterCounter)
            {
                Console.WriteLine($"letter {item.Key} appears {item.Value}times in the string");
            }
        }

        internal void FibonacciWithoutRecursion(int number)
        {
            var arrNumber = new int[number];
           // int initalNumber = 1;
            int fibbonacciNumber = 0;

            for (int i = 0; i < arrNumber.Length; i++)
            {


                Console.Write($"{fibbonacciNumber} ");
                arrNumber[i] = fibbonacciNumber;

                fibbonacciNumber = arrNumber[i] + fibbonacciNumber;

                //initalNumber = fibbonacciNumber;
                //fibbonacciNumber = i;
            }


        }



    }

}
