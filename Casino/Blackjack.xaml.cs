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

/*

 Functionality:
    shuffle and deal cards when deal is clicked updates things accordingly
    dealer stops drawing cards along with player at 16
    player can continue to draw cards until they click Stand or they have up to 5 cards
    player can draw a card with Hit and it updates things accordingly

    Find a way to get Deal to switch to Hit and allows both buttons to function sperately

 */

namespace Casino
{
    /// <summary>
    /// Interaction logic for Blackjack.xaml
    /// </summary>
    public partial class Blackjack : Window
    {
        int money;
        int bank; //Do not alter or Change, This is so that we can keep track of our Bank Amount ~ Tommy

        int bet = 0;
        int dealerStop = 16;

        int dealerCards = 0;
        int playerCards = 0;

        int dealerSum = 0;
        int playerSum = 0;

        public Blackjack(int money, int bank)
        {
            InitializeComponent();
            this.money = money;
            this.bank = bank;

            Money.Content = "$ " + money;
            PlayerSum.Content = playerCards;
        }

        //Go Back to Game Selection
        private void BackClicked(object sender, RoutedEventArgs e)
        {
            GameSelection gameSelection = new GameSelection(money, bank);
            gameSelection.Show();

            this.Close();
        }

        //Show Rules
        private void RulesClicked(object sender, RoutedEventArgs e)
        {
            string message = "-Win Money by having the closest card total to 21 without going over."
                + "\n-Hit: Take 1 card, up to 5 cards from the deck"
                + "\n-Stand: End your turn when you are done drawing cards"
                + "\n-Face Cards (Jack, King, Queen) count as a 10"
                + "\n\t-The Ace card counts as a 1"
                + "\n\t-All other number cards count as their number";
                
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
            btnDeal.IsEnabled = true;
        }

        private void DealClicked(object sender, RoutedEventArgs e)
        {
            //deal cards
            
            //stand available
            btnStand.IsEnabled = true;
            btnDeal.Content = "HIT";
            PlayerSum.Content = playerSum;
            
        }

        private void HitClicked(object sender, RoutedEventArgs e)
        {
            //draw 1 card up to 5 cards

            PlayerSum.Content = playerSum;
        }

        private void StandClicked(object sender, RoutedEventArgs e)
        {
            //do stand things.. idk
        }

        //Win
        private void Win()
        {
            money += bet;
            bet = 0;

            string Win = "Dealer: " + dealerCards + "\nPlayer: " + playerSum;

            MessageBox.Show(Win, "You Won!");

            btnChip1.IsEnabled = true;
            btnChip5.IsEnabled = true;
            btnChip10.IsEnabled = true;
            btnChip20.IsEnabled = true;
            btnChip50.IsEnabled = true;
            btnChip100.IsEnabled = true;
            btnChip1k.IsEnabled = true;

            btnStand.IsEnabled = false;
            btnDeal.Content = "DEAL";
            btnDeal.IsEnabled = false;
        }

        //Loss
        private void Loss()
        {
            bet = 0;

            string Loss = "Dealer: " + dealerCards + "\nPlayer: " + playerSum;

            MessageBox.Show(Loss, "You Lost!");

            btnChip1.IsEnabled = true;
            btnChip5.IsEnabled = true;
            btnChip10.IsEnabled = true;
            btnChip20.IsEnabled = true;
            btnChip50.IsEnabled = true;
            btnChip100.IsEnabled = true;
            btnChip1k.IsEnabled = true;

            btnStand.IsEnabled = true;
            btnDeal.Content = "DEAL";
            btnDeal.IsEnabled = false;
        }
    }
}
