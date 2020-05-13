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

namespace Galloons.View
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

        private void convertGallons_Click(object sender, RoutedEventArgs e)
        {
            int litres = 20;

            for (int i =litres ; i <= 60; i++)
            {
                var gallons = i * 4;

                listBoxResults.Items.Add($"for {i} gallons we have {gallons} litres");

                i += 4;
            }
        }
    }
}
