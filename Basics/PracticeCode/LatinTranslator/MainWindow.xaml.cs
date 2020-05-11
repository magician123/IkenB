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

namespace LatinTranslator
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

        private void Italian_Click(object sender, RoutedEventArgs e)
        {
            languageTextBox.Text = "Buongiorno";
        }

        private void Spanish_Click(object sender, RoutedEventArgs e)
        {
            languageTextBox.Text = "Buenos días";
        }

        private void German_Click(object sender, RoutedEventArgs e)
        {
            languageTextBox.Text = "guten Morgen";
        }
    }
}
