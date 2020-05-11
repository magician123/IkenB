using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberEvaluator
{
    public class Evaluator
    {

        public string EvaluateNumber(int number)
        {
            if (IsEvenNumber(number))
                return "The number is Even";
            else
                return "The number is Odd";
        }

        public bool IsEvenNumber(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
