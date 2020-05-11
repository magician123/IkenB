using System;

namespace QuestionOne
{
    public class USCoinSystem
    {
        private int _penny;

        public int HalfDollars(int amount)
        {
            int maximumNumberOfHalfDollars = 0;
            _penny = 50;

            maximumNumberOfHalfDollars = ChangeAmount(_penny, amount);

            return maximumNumberOfHalfDollars;
        }

        public int Quaters(int amount)
        {
            int maximumNumberOfQuaters = 0;
            _penny = 25;
            maximumNumberOfQuaters = amount / _penny;

            return maximumNumberOfQuaters;
        }

        public int Dimes(int amount)
        {
            int maximumNumberOfDimes = 0;
            _penny = 10;
            maximumNumberOfDimes = ChangeAmount(_penny, amount);

            return maximumNumberOfDimes;
        }

        public int Nickels(int amount)
        {
            int maximumNumberOfNickels = 0;
            _penny = 5;

            maximumNumberOfNickels = ChangeAmount(_penny, amount);

            return maximumNumberOfNickels;
        }

        public int ChangeAmount(int coin, int amount)
        {
            int result = 0;
            try
            {
                if (coin != 0)
                {
                    result = amount / coin;
                }
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("Cannot divide by zero "+ e.Message);
            }


            return result;

        }
    }
}