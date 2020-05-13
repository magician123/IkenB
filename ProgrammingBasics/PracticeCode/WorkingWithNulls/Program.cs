using System;

namespace WorkingWithNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //PlayerDisplayer playerDisplayer = new PlayerDisplayer();
            //PlayerCharacter playerCharacter = new PlayerCharacter();

            //playerDisplayer.Display(playerCharacter);

            //return;

        }

     

    }
    class PlayerCharacter
    {
        public string Name { get; set; }
        public int? DaysSinceLogin { get; set; }
        public DateTime? LastLoginDate { get; set; }



        public PlayerCharacter()
        {
            DaysSinceLogin = null;
            LastLoginDate = null;
        }
    }

    class PlayerDisplayer
    {
      
        public void Display(PlayerCharacter playerCharacter)
        {
            Console.WriteLine(playerCharacter.Name);
            if (playerCharacter.DaysSinceLogin == null)
                Console.WriteLine("Number of days since logon is zero");
            else
                Console.WriteLine($"logged on for {playerCharacter.DaysSinceLogin} days");

            if(playerCharacter.LastLoginDate == null)
                Console.WriteLine("Not logged on ever since");
            else
                Console.WriteLine(playerCharacter.LastLoginDate);
        }
    }

}
