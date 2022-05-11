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

namespace Casino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Craps craps = new Craps(1000);
            //Poker poker = new Poker(1000);
            //poker.Show();
            //this.Hide();
        }

        private void MainMenu(object sender, RoutedEventArgs e)
        {
            GameSelection gameSelection = new GameSelection(10000);
            gameSelection.Show();
            this.Close();
        }

        private void CreditsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
