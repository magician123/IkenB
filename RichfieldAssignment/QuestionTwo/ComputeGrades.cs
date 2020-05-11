using System;
using System.Collections.Generic;

namespace QuestionTwo
{
  
    public class ComputeGrades
    {
        double result = 0.0;
        double highGrade = double.MinValue;
        double lowGrade = double.MaxValue;
        private double _average;
        public double ComputeAverage(List<double> grades)
        {
            foreach (var grade in grades)
            {
                result += grade;

            }
            _average = result / grades.Count;

            return _average;
        }

        public double GetMax(List<double> grades)
        {
            foreach (var grade in grades)
            {         
                highGrade = Math.Max(grade, highGrade);       

            }

            return highGrade;
        }

        public double GetMin(List<double> grades)
        {
            foreach (var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);

            }

            return lowGrade;
        }

        public char DetermineLetterGrade(double numberGrade)
        {
            
            char letter = 'F';
            if (numberGrade >= 90 && numberGrade <= 100)
            {
             
                letter = 'A';
            }

            else if (numberGrade >= 80 && numberGrade < 90)
            {

                letter = 'B';
            }
            else if (numberGrade >= 70 && numberGrade < 80)
            {

                letter = 'C';
            }
            else if (numberGrade >= 60 && numberGrade < 70)
            {

                letter = 'D';
            }
           
            return letter;
        }



    }
}



       