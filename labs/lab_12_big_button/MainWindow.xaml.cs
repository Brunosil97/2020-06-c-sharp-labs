﻿using System;
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
using System.Diagnostics;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace lab_12_big_button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            displayText.Text = "This took: 0s";
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            string folderName = @"C:\2020-06-labs\2020-06-c-sharp-labs\labs\lab_12_big_button";
            string pathString = System.IO.Path.Combine(folderName, "textFolder");
            System.IO.Directory.CreateDirectory(pathString);

            for(int i = 0; i <= 100; i++)
            {
                string fileName = System.IO.Path.GetRandomFileName();
                pathString = System.IO.Path.Combine(pathString, fileName);
            }
            
            stopwatch.Stop();

            displayText.Text = $"This took: {stopwatch.Elapsed}s";
        }
    }
}
