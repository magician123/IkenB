using CardApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CardApplication.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Employee employee;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void buttonApply_Click(object sender, RoutedEventArgs e)
        {
            

            employee = new Employee()
            {
                ApplicationNumber = long.Parse(textBoxApplicationNumber.Text),
                Salary = double.Parse(textBoxSalary.Text),
                Rent = double.Parse(textRent.Text),
                YearsEmployed = int.Parse(textYearEmployed.Text),
                YearsResiding = int.Parse(textBoxYearsResiding.Text)
            };
    

            if (ProcessApplicationSucceds(employee))
                MessageBox.Show("Your application was succcessful");
            else
                MessageBox.Show("Application failed");
            
        }

        private bool ProcessApplicationSucceds(Employee employee)
        {
            bool isEligible = false;
            double minimumRent = 0.25 * employee.Salary;

            if(employee.Salary > 2500  && 
               employee.Rent < minimumRent && 
               employee.YearsResiding > 5 && 
               employee.YearsEmployed >3)
            {
                isEligible = true;
            }

            return isEligible;

        }
    }
}

    
