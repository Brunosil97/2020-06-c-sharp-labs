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
using RadioApp;

namespace RadioWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio radio1 = new Radio();
        public MainWindow()
        {
            InitializeComponent();

            
            RadioDisplay.Text = radio1.Play();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            radio1.TurnOn();
            RadioDisplay.Text = radio1.Play();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            radio1.TurnOff();
            RadioDisplay.Text = radio1.Play();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            radio1.Channel = 1;
            UncheckBoxes(1);
            RadioDisplay.Text = radio1.Play();
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            radio1.Channel = 2;
            UncheckBoxes(2);
            RadioDisplay.Text = radio1.Play();
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            radio1.Channel = 3;
            UncheckBoxes(3);
            RadioDisplay.Text = radio1.Play();
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            radio1.Channel = 4;
            UncheckBoxes(4);
            RadioDisplay.Text = radio1.Play();
        }

        public void UncheckBoxes(int channel)
        {
            switch(channel)
            {
                case 1:
                    channel2.IsChecked = false;
                    channel3.IsChecked = false;
                    channel4.IsChecked = false;
                    break;
                case 2:
                    channel1.IsChecked = false;
                    channel3.IsChecked = false;
                    channel4.IsChecked = false;
                    break;
                case 3:
                    channel2.IsChecked = false;
                    channel1.IsChecked = false;
                    channel4.IsChecked = false;
                    break;
                case 4:
                    channel2.IsChecked = false;
                    channel3.IsChecked = false;
                    channel1.IsChecked = false;
                    break;
            }
        }
    }
}
