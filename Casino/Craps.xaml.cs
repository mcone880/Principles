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
    /// Interaction logic for Craps.xaml
    /// </summary>
    public partial class Craps : Window
    {
        int credits;
        int bank; //Do not alter or Change, This is so that we can keep track of our Bank Amount ~ Tommy
        int bet = 0;
        Image[] Images = new Image[12];

        public Craps(int money, int bank)
        {
            InitializeComponent();
            this.bank = bank;
            credits = money;
            CrapsWindow.Width = 815;
            CrapsWindow.Height = 725;
            CrapsWindow.ResizeMode = ResizeMode.NoResize;
            lblMoney.Content = "Money: " + money.ToString();
            lblBet.Content = "Bet: " + bet;

            int j = 0;
            for (int i = 1; i < 7; i++)
            {
                Image img = (Image)FindName("Col1Dice" + i);
                Images[j] = img;
                j++;
            }
            for (int i = 1; i < 7; i++)
            {
                Image img = (Image)FindName("Col2Dice" + i);
                Images[j] = img;
                j++;
            }
        }

        public int[] Roll()
        {
            Random r = new Random();
            int dice1 = r.Next(1, 7);
            int dice2 = r.Next(1, 7);
            int total = dice1 + dice2;
            int[] nums = new int[3];
            nums[0] = dice1;
            nums[1] = dice2;
            nums[2] = total;

            return nums;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            GameSelection game = new GameSelection(credits, bank);
            game.Show();
            Close();
        }

        private void RollButton_Click(object sender, RoutedEventArgs e)
        {
            var results = Roll();
            SetImages(results[0], results[1]);



            bet = 0;
            lblBet.Content = "Bet: " + bet;
        }

        private void SetImages(int dice1, int dice2)
        {
            foreach (Image image in Images)
            {
                image.Visibility = Visibility.Hidden;
            }

            Image image1 = (Image)FindName("Col1Dice" + dice1);
            Image image2 = (Image)FindName("Col2Dice" + dice2);
            image1.Visibility = Visibility.Visible;
            image2.Visibility = Visibility.Visible;
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            if (sender == btn1 && bet + 1 <= credits) bet += 1;
            else if (sender == btn5 && bet + 5 <= credits) bet += 5;
            else if (sender == btn10 && bet + 10 <= credits) bet += 10;
            else if (sender == btn20 && bet + 20 <= credits) bet += 20;
            else if (sender == btn50 && bet + 50 <= credits) bet += 50;
            else if (sender == btn100 && bet + 100 <= credits) bet += 100;
            else if (sender == btn1000 && bet + 1000 <= credits) bet += 1000; 
            lblBet.Content = "Bet: " + bet;
        }
    }
}
