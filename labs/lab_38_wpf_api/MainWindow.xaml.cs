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
using premierLeagueApi;

namespace lab_38_wpf_api
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApiRequests _apiRequests = new ApiRequests();
        Standing standing = new Standing();
        public MainWindow()
        {
            InitializeComponent();
            PopulateListBox();
        }

        public void PopulateListBox()
        {
            
            _apiRequests.GetTeams();
            apiListBox.ItemsSource = _apiRequests.premierLeagueTeams;
        }
    }
}
