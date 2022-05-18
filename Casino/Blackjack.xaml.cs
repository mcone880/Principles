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
using System.Windows.Shapes;

namespace Casino
{
    /// <summary>
    /// Interaction logic for Blackjack.xaml
    /// </summary>
    public partial class Blackjack : Window
    {
        int money;
        int bet = 0;

        public Blackjack(int money)
        {
            InitializeComponent();
            this.money = money;

            Money.Content = "$ " + money;
        }

        //Go Back to Game Selection
        private void BackClicked(object sender, RoutedEventArgs e)
        {
            GameSelection gameSelection = new GameSelection(money);
            gameSelection.Show();

            this.Close();
        }

        //Show Rules
        private void RulesClicked(object sender, RoutedEventArgs e)
        {
            string message = "\t Objective: \n Win money by having the closest card total to 21, but nothing over 21. \n \t Hit: \n Take a card, up to 5 cards \n \t Stand: \n End turn \n \n Face Cards count as 10 whil Ace is 1";
            MessageBox.Show(message, "Blackjack Rules");
        }

        //Select Bet
        private void ChipClicked(object sender, RoutedEventArgs e)
        {
            switch((sender as Button).Name)
            {
                case "btnChip1":

                    if(money >= 1)
                    {
                        bet = 1;
                        money -= 1;

                        btnChip1.IsEnabled = false;
                        btnChip5.IsEnabled = false;
                        btnChip10.IsEnabled = false;
                        btnChip20.IsEnabled = false;
                        btnChip50.IsEnabled = false;
                        btnChip100.IsEnabled = false;
                        btnChip1k.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Not enough funds", "ERROR");
                    }

                    break;
                case "btnChip5":

                    if(money >= 5)
                    {
                        bet = 5;
                        money -= 5;

                        btnChip1.IsEnabled = false;
                        btnChip5.IsEnabled = false;
                        btnChip10.IsEnabled = false;
                        btnChip20.IsEnabled = false;
                        btnChip50.IsEnabled = false;
                        btnChip100.IsEnabled = false;
                        btnChip1k.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Not enough funds", "ERROR");
                    }

                    break;
                case "btnChip10":

                    if (money >= 10)
                    {
                        bet = 10;
                        money -= 10;

                        btnChip1.IsEnabled = false;
                        btnChip5.IsEnabled = false;
                        btnChip10.IsEnabled = false;
                        btnChip20.IsEnabled = false;
                        btnChip50.IsEnabled = false;
                        btnChip100.IsEnabled = false;
                        btnChip1k.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Not enough funds", "ERROR");
                    }

                    break;
                case "btnChip20":

                    if (money >= 20)
                    {
                        bet = 20;
                        money -= 20;

                        btnChip1.IsEnabled = false;
                        btnChip5.IsEnabled = false;
                        btnChip10.IsEnabled = false;
                        btnChip20.IsEnabled = false;
                        btnChip50.IsEnabled = false;
                        btnChip100.IsEnabled = false;
                        btnChip1k.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Not enough funds", "ERROR");
                    }

                    break;
                case "btnChip50":

                    if (money >= 50)
                    {
                        bet = 50;
                        money -= 50;

                        btnChip1.IsEnabled = false;
                        btnChip5.IsEnabled = false;
                        btnChip10.IsEnabled = false;
                        btnChip20.IsEnabled = false;
                        btnChip50.IsEnabled = false;
                        btnChip100.IsEnabled = false;
                        btnChip1k.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Not enough funds", "ERROR");
                    }

                    break;
                case "btnChip100":

                    if (money >= 100)
                    {
                        bet = 100;
                        money -= 100;

                        btnChip1.IsEnabled = false;
                        btnChip5.IsEnabled = false;
                        btnChip10.IsEnabled = false;
                        btnChip20.IsEnabled = false;
                        btnChip50.IsEnabled = false;
                        btnChip100.IsEnabled = false;
                        btnChip1k.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Not enough funds", "ERROR");
                    }

                    break;
                case "btnChip1k":

                    if (money >= 1000)
                    {
                        bet = 1000;
                        money -= 1000;

                        btnChip1.IsEnabled = false;
                        btnChip5.IsEnabled = false;
                        btnChip10.IsEnabled = false;
                        btnChip20.IsEnabled = false;
                        btnChip50.IsEnabled = false;
                        btnChip100.IsEnabled = false;
                        btnChip1k.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Not enough funds", "ERROR");
                    }

                    break;
                default:
                    break;
            }

            Money.Content = "$ " + money;
        }

        private void DealClicked(object sender, RoutedEventArgs e)
        {
            //deal cards

            //stand available
            btnStand.IsEnabled = true;
        }

        //Win
        private void Win()
        {
            money += bet;
            bet = 0;
        }

        //Loss
        private void Loss()
        {
            bet = 0;
        }
    }
}
