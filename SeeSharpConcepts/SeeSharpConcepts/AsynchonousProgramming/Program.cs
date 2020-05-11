using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchonousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
           // Task task = new Task(ContatenateCharacters);

             //task.Start();

            Console.WriteLine("Takes forver to create");
            Console.WriteLine("done");

            Console.ReadLine();
        }

        private async static Task ContatenateCharacters()
        {
            Task t =  Task.Factory.StartNew(() =>
            {
                var text = string.Empty;

                for (int i = 0; i < 200000; i++)
                {
                    text += 'o';
                }
            });

            await t;
        }      
    }
}
