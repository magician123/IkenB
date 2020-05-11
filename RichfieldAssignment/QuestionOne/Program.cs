using System;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            USCoinSystem uSCoin = new USCoinSystem();

            //Repeat this part for other functtions/methods
            var dime = uSCoin.Dimes(500);
            Console.WriteLine($"The Amount 500 can produce maximum of {dime} dimes");

            Console.ReadLine();
        }
    }
}
