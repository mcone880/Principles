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

namespace Casino
{ 
    /// <summary>
  /// Interaction logic for Slots.xaml
  /// </summary>
    public partial class Slots : Window
    {
        //public List<string> options = new { "Cherry", "Cherry", "Cherry", "Cherry", "Bells", "Bells", "Bells", "Bars", "Bars", "Sevens" };

        public Slots(int money)
        {
            InitializeComponent();
        }

        public void Spin()
        {
            //on click the spin

            //for each slot display an random image 


            checkForWin();
        }

        private void checkForWin()
        {
            /*Cherry(4 in 10 per Wheel) - 15:1
              Bells(3 in 10 per Wheel) - 35:1
              Bars(2 in 10 per Wheel) - 100:1
              Sevens(1 in 10 per Wheel) - 1000:1*/
            int payout = 1;
            //check and calculate pay out
            Payout(payout);
        }
        public void Payout(int payout)
        {
            //add to the balance

        }
        private void btnBack_Click(object sender, RoutedEventArgs e) // goes back to the game menu and closes this window 
        {
            GameSelection gameSelection = new GameSelection();
            gameSelection.Show();
            this.Close();
        }
    }
}
