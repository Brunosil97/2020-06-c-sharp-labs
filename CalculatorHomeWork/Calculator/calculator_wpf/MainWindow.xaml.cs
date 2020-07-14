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
using CalculatorLib;

namespace calculator_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number1 = 0;
        int number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                NumberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                NumberDisplay.Text = number2.ToString();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                NumberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                NumberDisplay.Text = number2.ToString();
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                NumberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                NumberDisplay.Text = number2.ToString();
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                NumberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                NumberDisplay.Text = number2.ToString();
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                NumberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                NumberDisplay.Text = number2.ToString();
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                NumberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                NumberDisplay.Text = number2.ToString();
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                NumberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                NumberDisplay.Text = number2.ToString();
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                NumberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                NumberDisplay.Text = number2.ToString();
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                NumberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                NumberDisplay.Text = number2.ToString();
            }
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                NumberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                NumberDisplay.Text = number2.ToString();
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            NumberDisplay.Text = "0";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            NumberDisplay.Text = "0";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            NumberDisplay.Text = "0";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            NumberDisplay.Text = "0";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    NumberDisplay.Text = Calculator.Add(number1, number2).ToString();
                    break;
                case "-":
                    NumberDisplay.Text = Calculator.Subtract(number1, number2).ToString();
                    break;
                case "*":
                    NumberDisplay.Text = Calculator.Multiply(number1, number2).ToString();
                    break;
                case "/":
                    NumberDisplay.Text = Calculator.Divide(number1, number2).ToString();
                    break;

            }
        }

        private void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            NumberDisplay.Text = "0";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            NumberDisplay.Text = "0";
        }
    }
}

