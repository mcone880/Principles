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
using System.Windows.Shapes;

namespace Nim
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        public Results(string player1, string player2)
        {
            InitializeComponent();
            Player1Label.Content = player1;
            Player2Label.Content = player2;
        }

        private void RematchButton_Click(object sender, RoutedEventArgs e)
        {
            //Start up a brand new game
        }

        private void StartOverButton_Click(object sender, RoutedEventArgs e)
        {
            Name newWindow = new Name();
            newWindow.Show();
            this.Close();
        }
    }
}
