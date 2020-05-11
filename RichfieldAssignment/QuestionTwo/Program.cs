using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{

    class Program
    {
        static void Main(string[] args)
        {
            Module module = new Module();
            double score = 0.0;
            int gradeCount = 0;


            Console.WriteLine("Welcome To The Grade Result:");

           

            while (gradeCount < 3)
            {
                Console.WriteLine($"Enter score {gradeCount + 1}");
                score = Double.Parse(Console.ReadLine());

                if (ValidScore(score))
                {
                    module.AddGrade(score);
                }
                else
                {
                    Console.WriteLine("Score entered is invalid");
                    return;
                }

                gradeCount++;
            }
           
            ComputeGrades computeGrades = new ComputeGrades();

            var average = computeGrades.ComputeAverage(module.Grades);
            var letterGrade = computeGrades.DetermineLetterGrade(average);
            var lowestGrade = computeGrades.GetMin(module.Grades);
            var higestGrade = computeGrades.GetMax(module.Grades);


            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The Letter Grade is {letterGrade}");

            Console.WriteLine($"The lowest grade is {lowestGrade}");
            Console.WriteLine($"The higest Grade is {higestGrade}");

            Console.ReadLine();


        }
        private static bool ValidScore(double score)
        {

            if (score >= 0 && score <= 100)
                return true;

            return
                false;

        }
    }
}
