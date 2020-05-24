using System;
using System.Windows;
using Calculator;
using System.Windows.Controls;

namespace Calculator.UI
{

    public enum SelectedOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber,secondNumber, result;
        string operation = string.Empty;
       
        Logic.Math math;

        public MainWindow()
        {
            InitializeComponent();
          
            math = new Logic.Math();
        }


      

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {

            secondNumber = Double.Parse(outputLabel.Content.ToString());

            switch (operation)
            {
                case "+":
                    result = math.AddNumbers(lastNumber, secondNumber);
                    break;

                case "-":
                    result = math.SubtractNumbers(lastNumber, secondNumber);
                    break;

                case "*":
                    result = math.MultiplyNumbers(lastNumber, secondNumber);
                    break;

                case "/":
                    result = math.DivideNumbers(lastNumber, secondNumber);
                    break;

            };

            outputLabel.Content = result.ToString();
        }

        private void NumberControl_Click(object sender, RoutedEventArgs e)
        {
            var control = sender as Button;
            var number = control.Content.ToString();

            if (outputLabel.Content.ToString() == "0")
            {
                outputLabel.Content = number;
            }

            else
            {
                outputLabel.Content = $"{outputLabel.Content}{number}";
            }

        }

        private void acButton_Click(object sender, RoutedEventArgs e)
        {
            outputLabel.Content = "0";
        }

        private void negativeButton_Click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(outputLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                outputLabel.Content = lastNumber.ToString();
            }
        }

       

        private void percentageButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(outputLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                outputLabel.Content = lastNumber.ToString();
            }

        }

       

        private void OperationControl_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(outputLabel.Content.ToString(), out lastNumber))
            {
                outputLabel.Content = "0";
            }

            var control = sender as Button;

            operation = control.Content.ToString();

        }

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            if(!outputLabel.Content.ToString().Contains("."))
            {
                outputLabel.Content = $"{outputLabel.Content}.";
            }
        }
    }

   
}
