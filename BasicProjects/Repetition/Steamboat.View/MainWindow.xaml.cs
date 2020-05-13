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

namespace Steamboat.View
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

        private void buttonProduce_Click(object sender, RoutedEventArgs e)
        {
            string text = "steamboat";

            for (int i = 0; i < 3; i++)
            {
                listBoxResults.Items.Add(text);
            }
            listBoxResults.Items.Add("CHARGE");
        }
    }
}
