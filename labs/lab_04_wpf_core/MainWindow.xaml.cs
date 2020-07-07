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

namespace lab_04_wpf_core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //windows
            InitializeComponent();
            LabelDisplay.Content = "0";
        }

        static string firstNumber = "0";
        static string secondNumber = "0";
        static string thirdNumber = "0";

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content = firstNumber + secondNumber + thirdNumber;
        }

        private void ButtonEquals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LabelDisplay.Content = "Don't Double Click";
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            firstNumber += "1";
        }

        private void Button02_Click(object sender, RoutedEventArgs e)
        {
            secondNumber += "2";
        }

        private void Button03_Click(object sender, RoutedEventArgs e)
        {
            thirdNumber += "3";
        }
    }
}
