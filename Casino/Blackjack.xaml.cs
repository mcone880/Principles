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
        int bank; //Do not alter or Change, This is so that we can keep track of our Bank Amount ~ Tommy

        int bet = 0;

        int dealerStop = 16;
        int dealerSum = 0;
        int dealerHand = 0;
        bool dealerDraw = true;

        int playerSum = 0;
        int playerHand = 0;

        Deck deck = new Deck();

        Cards playerCard1, playerCard2, playerCard3, playerCard4, playerCard5;
        Cards dealerCard1, dealerCard2, dealerCard3, dealerCard4, dealerCard5;

        public Blackjack(int money, int bank)
        {
            InitializeComponent();
            this.money = money;
            this.bank = bank;

            deck.Reset();
            deck.Shuffle();

            Money.Content = "$ " + money;
            PlayerSum.Content = playerSum;
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
                + "\n-Hit: Dealer deals you a card"
                + "\n-Stand: Take no more cards and stick with your current cards"
                + "\n-Betting: Place a bet using the chips"
                + "\n\t-If you win, get 2x the amount you bet"
                + "\n\t-If you lose, you lose the amount you bet"
                + "\n\t-If you tie with the dealer, take back your bet"
                + "\n-Face Cards (Jack, King, Queen) count as a 10"
                + "\n\t-The Ace card counts as a 1"
                + "\n\t-All other number cards count as their number"
                ;
                
            MessageBox.Show(message, "Blackjack Rules");
        }

        //Select Bet
        private void ChipClicked(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "btnChip1":

                    if(money >= 1)
                    {
                        bet = 1;

                        btnChip5.BorderBrush = null;
                        btnChip10.BorderBrush = null;
                        btnChip20.BorderBrush = null;
                        btnChip50.BorderBrush = null;
                        btnChip100.BorderBrush = null;
                        btnChip1k.BorderBrush = null;

                        btnChip1.BorderBrush = Brushes.Yellow;
                        btnChip1.BorderThickness = new Thickness(5, 5, 5, 5);

                        btnDeal.IsEnabled = true;
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

                        btnChip1.BorderBrush = null;
                        btnChip10.BorderBrush = null;
                        btnChip20.BorderBrush = null;
                        btnChip50.BorderBrush = null;
                        btnChip100.BorderBrush = null;
                        btnChip1k.BorderBrush = null;

                        btnChip5.BorderBrush = Brushes.Yellow;
                        btnChip5.BorderThickness = new Thickness(5, 5, 5, 5);

                        btnDeal.IsEnabled = true;
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

                        btnChip1.BorderBrush = null;
                        btnChip5.BorderBrush = null;
                        btnChip20.BorderBrush = null;
                        btnChip50.BorderBrush = null;
                        btnChip100.BorderBrush = null;
                        btnChip1k.BorderBrush = null;

                        btnChip10.BorderBrush = Brushes.Yellow;
                        btnChip10.BorderThickness = new Thickness(5, 5, 5, 5);

                        btnDeal.IsEnabled = true;
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

                        btnChip1.BorderBrush = null;
                        btnChip5.BorderBrush = null;
                        btnChip10.BorderBrush = null;
                        btnChip50.BorderBrush = null;
                        btnChip100.BorderBrush = null;
                        btnChip1k.BorderBrush = null;

                        btnChip20.BorderBrush = Brushes.Yellow;
                        btnChip20.BorderThickness = new Thickness(5, 5, 5, 5);

                        btnDeal.IsEnabled = true;
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

                        btnChip1.BorderBrush = null;
                        btnChip5.BorderBrush = null;
                        btnChip10.BorderBrush = null;
                        btnChip20.BorderBrush = null;
                        btnChip100.BorderBrush = null;
                        btnChip1k.BorderBrush = null;

                        btnChip50.BorderBrush = Brushes.Yellow;
                        btnChip50.BorderThickness = new Thickness(5, 5, 5, 5);

                        btnDeal.IsEnabled = true;
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

                        btnChip1.BorderBrush = null;
                        btnChip5.BorderBrush = null;
                        btnChip10.BorderBrush = null;
                        btnChip20.BorderBrush = null;
                        btnChip50.BorderBrush = null;
                        btnChip1k.BorderBrush = null;

                        btnChip100.BorderBrush = Brushes.Yellow;
                        btnChip100.BorderThickness = new Thickness(5, 5, 5, 5);

                        btnDeal.IsEnabled = true;
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

                        btnChip1.BorderBrush = null;
                        btnChip5.BorderBrush = null;
                        btnChip10.BorderBrush = null;
                        btnChip20.BorderBrush = null;
                        btnChip50.BorderBrush = null;
                        btnChip1k.BorderBrush = null;

                        btnChip1k.BorderBrush = Brushes.Yellow;
                        btnChip1k.BorderThickness = new Thickness(5, 5, 5, 5);

                        btnDeal.IsEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Not enough funds", "ERROR");
                    }

                    break;
                default:
                    break;
            }
        }

        private void DealClicked(object sender, RoutedEventArgs e)
        {
            //disable buttons
            btnChip1.IsEnabled = false;
            btnChip5.IsEnabled = false;
            btnChip10.IsEnabled = false;
            btnChip20.IsEnabled = false;
            btnChip50.IsEnabled = false;
            btnChip100.IsEnabled = false;
            btnChip1k.IsEnabled = false;

            btnBack.IsEnabled = false;

            btnDeal.IsEnabled = false;

            //enable buttons
            btnStand.IsEnabled = true;
            btnHit.IsEnabled = true;

            //deal cards
            playerCard1 = deck.TakeCard();
            playerCard2 = deck.TakeCard();

            dealerCard1 = deck.TakeCard();
            dealerCard2 = deck.TakeCard();

            //update Hand count
            playerHand += 2;
            dealerHand += 2;

            //update playerSum **King, Queen & Jack are set to 10
            UpdatePlayerSum(playerCard1);
            UpdatePlayerSum(playerCard2);

            //update dealerSum
            UpdateDealerSum(dealerCard1);
            UpdateDealerSum(dealerCard2);

            //update dealerDraw
            if(dealerSum >= dealerStop)
            {
                dealerDraw = false;
            }

            //dealer stuffs
            while (dealerDraw)
            {
                switch (dealerHand)
                {
                    case 2:
                        //dealer take card
                        dealerCard3 = deck.TakeCard();

                        //update dealer hand
                        dealerHand += 1;

                        //update playerSum
                        UpdateDealerSum(dealerCard3);

                        if (dealerSum >= dealerStop)
                        {
                            dealerDraw = false;
                        }

                        break;
                    case 3:
                        //dealer take card
                        dealerCard4 = deck.TakeCard();

                        //update dealer hand
                        dealerHand += 1;

                        //update playerSum
                        UpdateDealerSum(dealerCard4);

                        if (dealerSum >= dealerStop)
                        {
                            dealerDraw = false;
                        }

                        break;
                    case 4:
                        //dealer take card
                        dealerCard5 = deck.TakeCard();

                        //update dealer hand
                        dealerHand += 1;

                        //update playerSum
                        UpdateDealerSum(dealerCard5);

                        dealerDraw = false;

                        break;
                    default:
                        break;
                }
            }

            //remove bet amount from money
            money -= bet;

            //update UI
            PlayerCard1.Source = SetCardUI(playerCard1);
            PlayerCard2.Source = SetCardUI(playerCard2);

            DealerCard1.Source = SetCardUI(dealerCard1);

            Money.Content = "$ " + money;
        }

        private void HitClicked(object sender, RoutedEventArgs e)
        {
            switch (playerHand)
            {
                case 2:
                    //take card
                    playerCard3 = deck.TakeCard();

                    //update hand
                    playerHand += 1;

                    //update playerSum
                    UpdatePlayerSum(playerCard3);

                    //update UI
                    PlayerCard3.Source = SetCardUI(playerCard3);

                    Check21();

                    break;
                case 3:
                    //take card
                    playerCard4 = deck.TakeCard();

                    //update hand
                    playerHand += 1;

                    //update playerSum
                    UpdatePlayerSum(playerCard4);

                    //update UI
                    PlayerCard4.Source = SetCardUI(playerCard4);

                    Check21();

                    break;
                case 4:
                    //take card
                    playerCard5 = deck.TakeCard();

                    //update hand
                    playerHand += 1;

                    //update playerSum
                    UpdatePlayerSum(playerCard5);

                    //update UI
                    PlayerCard5.Source = SetCardUI(playerCard5);

                    Check21();

                    btnHit.IsEnabled = false;

                    break;
                default:
                    break;
            }
        }

        private void StandClicked(object sender, RoutedEventArgs e)
        {
            //disable Hit
            btnHit.IsEnabled = false;

            //show Dealers card
            DealerCard3.Visibility = Visibility.Visible;
            DealerCard4.Visibility = Visibility.Visible;
            DealerCard5.Visibility = Visibility.Visible;

            DealerCard2.Source = SetCardUI(dealerCard2);

            if(dealerCard3 != null)
            {
                DealerCard3.Source = SetCardUI(dealerCard3);
            }
            if(dealerCard4 != null)
            {
                DealerCard4.Source = SetCardUI(dealerCard4);
            }
            if(dealerCard5 != null)
            {
                DealerCard5.Source = SetCardUI(dealerCard5);
            }

            //Win check
            Check();
        }

        private BitmapImage SetCardUI(Cards card)
        {
            string cardURL = deck.DisplayCard(card);

            BitmapImage bmi = new BitmapImage();

            bmi.BeginInit();
            bmi.UriSource = new Uri(cardURL, UriKind.Relative);
            bmi.EndInit();

            return bmi;
        }

        private void UpdatePlayerSum(Cards playerCard)
        {
            if (playerCard.CardNumber == Cards.eCardNumber.King || playerCard.CardNumber == Cards.eCardNumber.Queen || playerCard.CardNumber == Cards.eCardNumber.Jack)
            {
                playerSum += 10;
            }
            else
            {
                playerSum += (int)playerCard.CardNumber;
            }

            PlayerSum.Content = playerSum;
        }

        private void UpdateDealerSum(Cards dealerCard)
        {
            if (dealerCard.CardNumber == Cards.eCardNumber.King || dealerCard.CardNumber == Cards.eCardNumber.Queen || dealerCard.CardNumber == Cards.eCardNumber.Jack)
            {
                dealerSum += 10;
            }
            else
            {
                dealerSum += (int)dealerCard.CardNumber;
            }
        }

        private void Check()
        {

/*            if (playerSum == 21)
            {
                Win();
            }*/

            if (dealerSum > 21 && playerSum < 21)
            {
                Win();
            }
            else if (playerSum > dealerSum && playerSum < 21 && dealerSum < 21)
            {
                Win();
            }

/*            else if (playerSum > 21 && dealerSum < 21)
            {
                Loss();
            }*/

            else if (dealerSum == 21)
            {
                Loss();
            }
            else if (dealerSum > playerSum && playerSum < 21 && dealerSum < 21)
            {
                Loss();
            }

            else if (dealerSum == playerSum)
            {
                Draw();
            }
            else if (dealerSum > 21 && playerSum > 21)
            {
                Draw();
            }
        }

        private void Check21()
        {
            if(playerSum == 21 && (dealerSum < 21 || dealerSum > 21))
            {
                //show Dealers card
                DealerCard3.Visibility = Visibility.Visible;
                DealerCard4.Visibility = Visibility.Visible;
                DealerCard5.Visibility = Visibility.Visible;

                DealerCard2.Source = SetCardUI(dealerCard2);

                if (dealerCard3 != null)
                {
                    DealerCard3.Source = SetCardUI(dealerCard3);
                }
                if (dealerCard4 != null)
                {
                    DealerCard4.Source = SetCardUI(dealerCard4);
                }
                if (dealerCard5 != null)
                {
                    DealerCard5.Source = SetCardUI(dealerCard5);
                }

                Win();
            }
            else if(playerSum > 21 && dealerSum < 21)
            {
                //show Dealers card
                DealerCard3.Visibility = Visibility.Visible;
                DealerCard4.Visibility = Visibility.Visible;
                DealerCard5.Visibility = Visibility.Visible;

                DealerCard2.Source = SetCardUI(dealerCard2);

                if (dealerCard3 != null)
                {
                    DealerCard3.Source = SetCardUI(dealerCard3);
                }
                if (dealerCard4 != null)
                {
                    DealerCard4.Source = SetCardUI(dealerCard4);
                }
                if (dealerCard5 != null)
                {
                    DealerCard5.Source = SetCardUI(dealerCard5);
                }

                Loss();
            }
            else if(playerSum > 21 && dealerSum > 21)
            {
                //show Dealers card
                DealerCard3.Visibility = Visibility.Visible;
                DealerCard4.Visibility = Visibility.Visible;
                DealerCard5.Visibility = Visibility.Visible;

                DealerCard2.Source = SetCardUI(dealerCard2);

                if (dealerCard3 != null)
                {
                    DealerCard3.Source = SetCardUI(dealerCard3);
                }
                if (dealerCard4 != null)
                {
                    DealerCard4.Source = SetCardUI(dealerCard4);
                }
                if (dealerCard5 != null)
                {
                    DealerCard5.Source = SetCardUI(dealerCard5);
                }

                Draw();
            }
            else if(playerSum == 21 && dealerSum == 21)
            {
                //show Dealers card
                DealerCard3.Visibility = Visibility.Visible;
                DealerCard4.Visibility = Visibility.Visible;
                DealerCard5.Visibility = Visibility.Visible;

                DealerCard2.Source = SetCardUI(dealerCard2);

                if (dealerCard3 != null)
                {
                    DealerCard3.Source = SetCardUI(dealerCard3);
                }
                if (dealerCard4 != null)
                {
                    DealerCard4.Source = SetCardUI(dealerCard4);
                }
                if (dealerCard5 != null)
                {
                    DealerCard5.Source = SetCardUI(dealerCard5);
                }

                Draw();
            }
        }

        //Win
        private void Win()
        {
            //Payout
            money += bet * 2;

            //notify the player
            Notify("You Won!");

            //reset things
            Reset();
        }

        //Loss
        private void Loss()
        {
            /*
                Loss
                   bet not returned *
                   Reset all cards *
                   reset bet to 0 *
                   reset UI *
                   enable bet buttons *
                   enable Back button *
                   disable Stand button *
                   notify player they lost *
             */

            //Payout
            money += 0;

            //notify player
            Notify("You Lost!");

            //reset
            Reset();
        }

        //Draw
        private void Draw()
        {
            /*
                Draw
                   bet return exact *
                   Reset all cards *
                   reset bet to 0 *
                   reset UI *
                   enable bet buttons *
                   enable Back button *
                   disable Stand button *
                   notify player its a draw *
             */

            //Payout
            money += bet;

            //notify player
            Notify("It's a Draw!");

            //reset
            Reset();
        }

        private void Reset()
        {
            //reset bet
            bet = 0;

            //reset buttons
            btnChip1.IsEnabled = true;
            btnChip5.IsEnabled = true;
            btnChip10.IsEnabled = true;
            btnChip20.IsEnabled = true;
            btnChip50.IsEnabled = true;
            btnChip100.IsEnabled = true;
            btnChip1k.IsEnabled = true;

            btnBack.IsEnabled = true;

            btnStand.IsEnabled = false;
            btnHit.IsEnabled = false;

            //reset cards
            playerCard1 = new Cards();
            playerCard2 = new Cards();
            playerCard3 = new Cards();
            playerCard4 = new Cards();
            playerCard5 = new Cards();

            dealerCard1 = new Cards();
            dealerCard2 = new Cards();
            dealerCard3 = new Cards();
            dealerCard4 = new Cards();
            dealerCard5 = new Cards();

            //reset UI
            string cardURL = "Assets/BlackJack/Cards/cardBack_blue1.png";

            BitmapImage bmi = new BitmapImage();

            bmi.BeginInit();
            bmi.UriSource = new Uri(cardURL, UriKind.Relative);
            bmi.EndInit();

            PlayerCard1.Source = bmi;
            PlayerCard2.Source = bmi;
            PlayerCard3.Source = bmi;
            PlayerCard4.Source = bmi;
            PlayerCard5.Source = bmi;

            DealerCard1.Source = bmi;
            DealerCard2.Source = bmi;
            DealerCard3.Source = bmi;
            DealerCard4.Source = bmi;
            DealerCard5.Source = bmi;

            btnChip1.BorderBrush = null;
            btnChip5.BorderBrush = null;
            btnChip10.BorderBrush = null;
            btnChip20.BorderBrush = null;
            btnChip50.BorderBrush = null;
            btnChip100.BorderBrush = null;
            btnChip1k.BorderBrush = null;

            Money.Content = "$ " + money;
            PlayerSum.Content = 0;

            //reset deck
            deck = new Deck();

            deck.Reset();
            deck.Shuffle();

            //reset player stats
            playerSum = 0;
            playerHand = 0;

            //reset dealer stats
            dealerSum = 0;
            dealerHand = 0;
            dealerDraw = true;
        }

        private void Notify(string outcome)
        {
            string input = "Dealer: " + dealerSum + "\nPlayer: " + playerSum;

            MessageBox.Show(input, outcome);
        }

    }
}
