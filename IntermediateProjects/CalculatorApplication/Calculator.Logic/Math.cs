using System;

namespace Calculator.Logic
{
    public class Math
    {
 
        public double AddNumbers(double firstNumber, double secondNumber )
        {      
            return firstNumber + secondNumber;
        }
        public double SubtractNumbers(double firstNumber, double secondNumber)
        {  
            return firstNumber - secondNumber;
        }
        public double DivideNumbers(double firstNumber, double secondNumber)
        {       
            if (secondNumber != 0)
                return firstNumber / secondNumber;
            else
                return 0;
        }
        public double MultiplyNumbers(double firstNumber, double secondNumber)
        {          
            return firstNumber * secondNumber;
        }


       
    }
}
