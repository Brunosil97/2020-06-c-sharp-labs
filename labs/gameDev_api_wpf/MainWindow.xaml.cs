using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
using gameDev_api_client;
using gameDev_api_client.Models;

namespace gameDev_api_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Program restApi = new Program();
        public MainWindow()
        {
            InitializeComponent();
            restApi.GetAllDevelopers();
            restApi.GetAllGames();
            PopulateDeveloperBox();
            PopulateGamesBox();
        }

        public void PopulateDeveloperBox()
        {
            restApi.GetAllDevelopers();
            gameDevs.ItemsSource = restApi.developers;
            allDevs.ItemsSource = restApi.developers;
        }

        public void PopulateGamesBox()
        {
            restApi.GetAllGames();
            gamesList.ItemsSource = restApi.games;
        }

        public void PopulateDevFields()
        {
            var selectedDev = restApi.SelectedDeveloper;
            if (selectedDev != null)
            {
                devName.Text = selectedDev.DevName;
                devDescription.Text = selectedDev.DevDescription;
            }
        }

        public void PopulateGameFields()
        {
            var selectedGame = restApi.SelectedGame;
            if(selectedGame != null)
            {
                gameNameBox.Text = selectedGame.GameName;
                gameDescriptionBox.Text = selectedGame.GameDescription;
            }
        }

        public void ClearDevFields()
        {
            devName.Text = "";
            devDescription.Text = "";
        }

        public void ClearGameFields()
        {
            gameDescriptionBox.Text = "";
            gameNameBox.Text = "";
        }
        private void addDev_Click(object sender, RoutedEventArgs e)
        {
            restApi.AddNewDeveloper(devName.Text, devDescription.Text);
            PopulateDeveloperBox();
            ClearDevFields();
        }

        private void deleteDev_Click(object sender, RoutedEventArgs e)
        {
            var selectedDev = restApi.SelectedDeveloper;
            if (selectedDev != null)
            {
                restApi.DeleteDeveloper(restApi.SelectedDeveloper.DevId);
                PopulateDeveloperBox();
                ClearDevFields();
            }
        }

        private void updateDev_Click(object sender, RoutedEventArgs e)
        {
            var selectedDev = restApi.SelectedDeveloper;
            if (selectedDev != null)
            {
                restApi.UpdateDeveloper(selectedDev, devName.Text, devDescription.Text);
                PopulateDeveloperBox();
                ClearDevFields();
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Games newGame = new Games()
            {
                GameName = gameNameBox.Text,
                GameDescription = gameDescriptionBox.Text,
                DevId = restApi.DropDownDev.DevId
            };
            restApi.AddANewGame(newGame);
            PopulateGamesBox();
        }

        private void updateGame_Click(object sender, RoutedEventArgs e)
        {
            var selectedGame = restApi.SelectedGame;
            if(selectedGame != null)
            {
                restApi.UpdateGame(selectedGame, gameNameBox.Text, gameDescriptionBox.Text);
                PopulateGamesBox();
                ClearGameFields();
            }
        }

        private void deleteGame_Click(object sender, RoutedEventArgs e)
        {
            var selectedGame = restApi.SelectedGame;
            if(selectedGame != null)
            {
                restApi.DeleteGame(selectedGame.GameId);
                PopulateGamesBox();
                ClearGameFields();
            }
        }

        private void allDevs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (allDevs.SelectedItem != null)
            {
                restApi.SetDropDownDev(allDevs.SelectedItem);
                PopulateGamesBox();
                ClearGameFields();
            }
        }

        private void gameDevs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gameDevs.SelectedItem != null)
            {
                restApi.setSelectedDeveloper(gameDevs.SelectedItem);
                PopulateDevFields();
            }
        }
        private void games_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(gamesList.SelectedItem != null)
            {
                restApi.SetSelectedGame(gamesList.SelectedItem);
                PopulateGameFields();
            }
        }

  
    }
}
