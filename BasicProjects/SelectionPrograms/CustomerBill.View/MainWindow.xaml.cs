using System;
using System.Collections.Generic;
using System.Linq;
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

namespace CustomerBill.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        float price1 = 2.8f;
        float price2 = 0.08f;
        float price3 = 0.06f;

        private void calculateBill_Click(object sender, RoutedEventArgs e)
        {
            float enteredKiloWatts = float.Parse(textBoxKiloWatts.Text);

            float result = ProcessKiloWatt(enteredKiloWatts);

            MessageBox.Show($"The bill is {result}");
        }

        private float ProcessKiloWatt(float enteredKiloWatts)
        {
            float results = 0.0f;

            if(enteredKiloWatts <= 12)
            {
               results = price1;
            }

            else if(enteredKiloWatts > 12 && enteredKiloWatts <= 90)
            {
                results = price1 + ((enteredKiloWatts - 12) * price2);
            }

            else if (enteredKiloWatts > 90)
            {
                results = price1 + (78 * price2) + ((enteredKiloWatts - 90) * price3);
            }

            return results;
        }
    }
}
