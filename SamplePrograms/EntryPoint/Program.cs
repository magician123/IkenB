using BinaryTriangle;
using Duplicate;
using Factorial;
using FibonacciSeries;
using Occurrence;
using Palindrone;
using Sort;
using Statistics;
using Swap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryPoint
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // TriangleBuilder triagleBuilder = new TriangleBuilder();
            // triagleBuilder.PrintTriangle();


            //ComputePalindrome computePalindrome = new ComputePalindrome();
            //computePalindrome.ValidatePalindrome();

            // CalculateFactorial calculateFactorial = new CalculateFactorial();
            // calculateFactorial.PrintFactorial();

            // ComputeStatistics computeStatistics = new ComputeStatistics();
            // computeStatistics.GetUserInput();

            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.GetData();

            //Reverse reverse = new Reverse();
            //reverse.GetText();

            //CharOccurrence charOccurrence = new CharOccurrence();
            //charOccurrence.GetText();

            //DuplicatedCharacter duplicatedCharacters = new DuplicatedCharacter();
            //duplicatedCharacters.GetInputText();

            Fibonacci fibonacci = new Fibonacci();
            fibonacci.GetElementNumber();

            Console.ReadLine();
        }
    }
}
