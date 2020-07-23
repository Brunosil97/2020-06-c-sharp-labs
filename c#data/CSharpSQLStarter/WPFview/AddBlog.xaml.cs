using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFview
{
    /// <summary>
    /// Interaction logic for AddBlog.xaml
    /// </summary>
    public partial class AddBlog : Window
    {
        public AddBlog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).CreateNewBlog(urlInput.Text, authorInput.Text);
            this.Close();
        }
    }
}
