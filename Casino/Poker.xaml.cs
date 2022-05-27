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
    /// Interaction logic for Poker.xaml
    /// </summary>
    public partial class Poker : Window
    {
        int money;
        int bank; //Do not alter or Change, This is so that we can keep track of our Bank Amount ~ Tommy
        int betMoney = 0;
        bool firstDraw = false;
        bool gameSet = true;
        string betAmount;
        Deck deck = new Deck();

        Cards card1, card2, card3, card4, card5;

        public Poker(int money, int bank)
        {
            InitializeComponent();
            this.money = money;
            this.bank = bank;

            txtMoney.Text = "$" + money;

            deck.Reset();
            deck.Shuffle();

            ResetCardButtonImage(btnHold1);
            ResetCardButtonImage(btnHold2);
            ResetCardButtonImage(btnHold3);
            ResetCardButtonImage(btnHold4);
            ResetCardButtonImage(btnHold5);
        }

        private void CheckWin() 
        {
            //MessageBox.Show("Made it to the win check! Unfortunately, I have not yet finished the win check.");

            int card1Number = 0;
            int card2Number = 0;
            int card3Number = 0;
            int card4Number = 0;
            int card5Number = 0;

            if (card1Number == 0)
            {
                if (card1.CardNumber == Cards.eCardNumber.Ace) card1Number = 1; 
                else if (card1.CardNumber == Cards.eCardNumber.Two) card1Number = 2; 
                else if (card1.CardNumber == Cards.eCardNumber.Three) card1Number = 3; 
                else if (card1.CardNumber == Cards.eCardNumber.Four) card1Number = 4; 
                else if (card1.CardNumber == Cards.eCardNumber.Five) card1Number = 5; 
                else if (card1.CardNumber == Cards.eCardNumber.Six) card1Number = 6; 
                else if (card1.CardNumber == Cards.eCardNumber.Seven) card1Number = 7; 
                else if (card1.CardNumber == Cards.eCardNumber.Eight) card1Number = 8; 
                else if (card1.CardNumber == Cards.eCardNumber.Nine) card1Number = 9; 
                else if (card1.CardNumber == Cards.eCardNumber.Ten) card1Number = 10; 
                else if (card1.CardNumber == Cards.eCardNumber.Jack) card1Number = 11; 
                else if (card1.CardNumber == Cards.eCardNumber.Queen) card1Number = 12; 
                else if (card1.CardNumber == Cards.eCardNumber.King) card1Number = 13;
                else Console.WriteLine("Card1 number not set correctly.");
            }
            if (card2Number == 0)
            {
                if (card2.CardNumber == Cards.eCardNumber.Ace) card1Number = 1;
                else if (card2.CardNumber == Cards.eCardNumber.Two) card1Number = 2;
                else if (card2.CardNumber == Cards.eCardNumber.Three) card1Number = 3;
                else if (card2.CardNumber == Cards.eCardNumber.Four) card1Number = 4;
                else if (card2.CardNumber == Cards.eCardNumber.Five) card1Number = 5;
                else if (card2.CardNumber == Cards.eCardNumber.Six) card1Number = 6;
                else if (card2.CardNumber == Cards.eCardNumber.Seven) card1Number = 7;
                else if (card2.CardNumber == Cards.eCardNumber.Eight) card1Number = 8;
                else if (card2.CardNumber == Cards.eCardNumber.Nine) card1Number = 9;
                else if (card2.CardNumber == Cards.eCardNumber.Ten) card1Number = 10;
                else if (card2.CardNumber == Cards.eCardNumber.Jack) card1Number = 11;
                else if (card2.CardNumber == Cards.eCardNumber.Queen) card1Number = 12;
                else if (card2.CardNumber == Cards.eCardNumber.King) card1Number = 13;
                else Console.WriteLine("Card1 number not set correctly.");
            }
            if (card3Number == 0)
            {
                if (card3.CardNumber == Cards.eCardNumber.Ace) card1Number = 1;
                else if (card3.CardNumber == Cards.eCardNumber.Two) card1Number = 2;
                else if (card3.CardNumber == Cards.eCardNumber.Three) card1Number = 3;
                else if (card3.CardNumber == Cards.eCardNumber.Four) card1Number = 4;
                else if (card3.CardNumber == Cards.eCardNumber.Five) card1Number = 5;
                else if (card3.CardNumber == Cards.eCardNumber.Six) card1Number = 6;
                else if (card3.CardNumber == Cards.eCardNumber.Seven) card1Number = 7;
                else if (card3.CardNumber == Cards.eCardNumber.Eight) card1Number = 8;
                else if (card3.CardNumber == Cards.eCardNumber.Nine) card1Number = 9;
                else if (card3.CardNumber == Cards.eCardNumber.Ten) card1Number = 10;
                else if (card3.CardNumber == Cards.eCardNumber.Jack) card1Number = 11;
                else if (card3.CardNumber == Cards.eCardNumber.Queen) card1Number = 12;
                else if (card3.CardNumber == Cards.eCardNumber.King) card1Number = 13;
                else Console.WriteLine("Card1 number not set correctly.");
            }
            if (card4Number == 0)
            {
                if (card4.CardNumber == Cards.eCardNumber.Ace) card1Number = 1;
                else if (card4.CardNumber == Cards.eCardNumber.Two) card1Number = 2;
                else if (card4.CardNumber == Cards.eCardNumber.Three) card1Number = 3;
                else if (card4.CardNumber == Cards.eCardNumber.Four) card1Number = 4;
                else if (card4.CardNumber == Cards.eCardNumber.Five) card1Number = 5;
                else if (card4.CardNumber == Cards.eCardNumber.Six) card1Number = 6;
                else if (card4.CardNumber == Cards.eCardNumber.Seven) card1Number = 7;
                else if (card4.CardNumber == Cards.eCardNumber.Eight) card1Number = 8;
                else if (card4.CardNumber == Cards.eCardNumber.Nine) card1Number = 9;
                else if (card4.CardNumber == Cards.eCardNumber.Ten) card1Number = 10;
                else if (card4.CardNumber == Cards.eCardNumber.Jack) card1Number = 11;
                else if (card4.CardNumber == Cards.eCardNumber.Queen) card1Number = 12;
                else if (card4.CardNumber == Cards.eCardNumber.King) card1Number = 13;
                else Console.WriteLine("Card1 number not set correctly.");
            }
            if (card5Number == 0)
            {
                if (card5.CardNumber == Cards.eCardNumber.Ace) card1Number = 1;
                else if (card5.CardNumber == Cards.eCardNumber.Two) card1Number = 2;
                else if (card5.CardNumber == Cards.eCardNumber.Three) card1Number = 3;
                else if (card5.CardNumber == Cards.eCardNumber.Four) card1Number = 4;
                else if (card5.CardNumber == Cards.eCardNumber.Five) card1Number = 5;
                else if (card5.CardNumber == Cards.eCardNumber.Six) card1Number = 6;
                else if (card5.CardNumber == Cards.eCardNumber.Seven) card1Number = 7;
                else if (card5.CardNumber == Cards.eCardNumber.Eight) card1Number = 8;
                else if (card5.CardNumber == Cards.eCardNumber.Nine) card1Number = 9;
                else if (card5.CardNumber == Cards.eCardNumber.Ten) card1Number = 10;
                else if (card5.CardNumber == Cards.eCardNumber.Jack) card1Number = 11;
                else if (card5.CardNumber == Cards.eCardNumber.Queen) card1Number = 12;
                else if (card5.CardNumber == Cards.eCardNumber.King) card1Number = 13;
                else Console.WriteLine("Card1 number not set correctly.");
            }

            List<int> cardNumbers = new List<int> { card1Number, card2Number, card3Number, card4Number, card5Number };
            cardNumbers.Sort();

            // win checks 
            if (card1 == null)
            {
                MessageBox.Show("Cards didn't get set.");
            }
            else if (card1.Suit == card2.Suit && card1.Suit == card3.Suit && card1.Suit == card4.Suit && card1.Suit == card5.Suit &&
                    cardNumbers.Contains(1) && cardNumbers.Contains(10) && cardNumbers.Contains(11) && cardNumbers.Contains(12) && cardNumbers.Contains(13))
            {
                // royal flush - 100,000:1
                betMoney *= 100000;
                money += betMoney;
                txtMoney.Text = "$" + money;
                txtWinAmount.Content = "You won $" + betMoney + "!";
                txtWinAmount.Visibility = Visibility.Visible;
            }
            else if (card1.Suit == card2.Suit && card1.Suit == card3.Suit && card1.Suit == card4.Suit && card1.Suit == card5.Suit &&
                    card2Number == card1Number - 1 && card3Number == card2Number - 1 && card4Number == card3Number - 1 && card5Number == card4Number - 1)
            {
                // straight flush - 10,000:1
                betMoney *= 10000;
                money += betMoney;
                txtMoney.Text = "$" + money;
                txtWinAmount.Content = "You won $" + betMoney + "!";
                txtWinAmount.Visibility = Visibility.Visible;
            }
            else if ((card1.CardNumber == card2.CardNumber && card1.CardNumber == card3.CardNumber && card1.CardNumber == card4.CardNumber) || // 1+2+3+4
                (card1.CardNumber == card2.CardNumber && card1.CardNumber == card3.CardNumber && card1.CardNumber == card5.CardNumber) ||      // 1+2+3+5
                (card2.CardNumber == card3.CardNumber && card2.CardNumber == card4.CardNumber && card2.CardNumber == card5.CardNumber))        // 2+3+4+5
            {
                // four of a kind - 1,000:1
                betMoney *= 1000;
                money += betMoney;
                txtMoney.Text = "$" + money;
                txtWinAmount.Content = "You won $" + betMoney + "!";
                txtWinAmount.Visibility = Visibility.Visible;
            }
            else if (card1Number == card2Number && card1Number == card3Number && card4Number == card5Number)
            {
                // full house - 100:1
                betMoney *= 100;
                money += betMoney;
                txtMoney.Text = "$" + money;
                txtWinAmount.Content = "You won $" + betMoney + "!";
                txtWinAmount.Visibility = Visibility.Visible;
            }
            else if (card1.Suit == card2.Suit && card1.Suit == card3.Suit && card1.Suit == card4.Suit && card1.Suit == card5.Suit)
            {
                // flush - 50:1 
                betMoney *= 50;
                money += betMoney;
                txtMoney.Text = "$" + money;
                txtWinAmount.Content = "You won $" + betMoney + "!";
                txtWinAmount.Visibility = Visibility.Visible;
            }
            else if (card2Number == card1Number - 1 && card3Number == card2Number - 1 && card4Number == card3Number - 1 && card5Number == card4Number - 1)
            {
                // straight - 25:1
                betMoney *= 25;
                money += betMoney;
                txtMoney.Text = "$" + money;
                txtWinAmount.Content = "You won $" + betMoney + "!";
                txtWinAmount.Visibility = Visibility.Visible;
            }
            else if ((card1.CardNumber == card2.CardNumber && card1.CardNumber == card3.CardNumber) || // 1+2+3
                (card1.CardNumber == card2.CardNumber && card1.CardNumber == card4.CardNumber) ||      // 1+2+4
                (card1.CardNumber == card2.CardNumber && card1.CardNumber == card5.CardNumber) ||      // 1+2+5
                (card1.CardNumber == card3.CardNumber && card1.CardNumber == card4.CardNumber) ||      // 1+3+4
                (card1.CardNumber == card3.CardNumber && card1.CardNumber == card5.CardNumber) ||      // 1+3+5
                (card2.CardNumber == card3.CardNumber && card2.CardNumber == card4.CardNumber) ||      // 2+3+4
                (card2.CardNumber == card3.CardNumber && card2.CardNumber == card5.CardNumber) ||      // 2+3+5
                (card2.CardNumber == card4.CardNumber && card2.CardNumber == card5.CardNumber) ||      // 2+4+5
                (card3.CardNumber == card4.CardNumber && card3.CardNumber == card5.CardNumber))        // 3+4+5
            {
                // three of a kind - 10:1 
                betMoney *= 10;
                money += betMoney;
                txtMoney.Text = "$" + money;
                txtWinAmount.Content = "You won $" + betMoney + "!";
                txtWinAmount.Visibility = Visibility.Visible;
            }
            else if ((card1.CardNumber == card2.CardNumber) && (card3.CardNumber == card4.CardNumber) || // 1+2 and 3+4
                     (card1.CardNumber == card2.CardNumber) && (card3.CardNumber == card5.CardNumber) || // 1+2 and 3+5
                     (card1.CardNumber == card2.CardNumber) && (card4.CardNumber == card5.CardNumber) || // 1+2 and 4+5
                     (card1.CardNumber == card3.CardNumber) && (card2.CardNumber == card4.CardNumber) || // 1+3 and 2+4
                     (card1.CardNumber == card3.CardNumber) && (card2.CardNumber == card5.CardNumber) || // 1+3 and 2+5
                     (card1.CardNumber == card3.CardNumber) && (card4.CardNumber == card5.CardNumber) || // 1+3 and 4+5
                     (card1.CardNumber == card4.CardNumber) && (card2.CardNumber == card3.CardNumber) || // 1+4 and 2+3
                     (card1.CardNumber == card4.CardNumber) && (card2.CardNumber == card5.CardNumber) || // 1+4 and 2+5
                     (card1.CardNumber == card4.CardNumber) && (card3.CardNumber == card5.CardNumber) || // 1+4 and 3+4
                     (card1.CardNumber == card5.CardNumber) && (card2.CardNumber == card3.CardNumber) || // 1+5 and 2+3
                     (card1.CardNumber == card5.CardNumber) && (card2.CardNumber == card4.CardNumber) || // 1+5 and 2+4
                     (card1.CardNumber == card5.CardNumber) && (card3.CardNumber == card4.CardNumber) || // 1+5 and 3+4
                     (card2.CardNumber == card3.CardNumber) && (card4.CardNumber == card5.CardNumber) || // 2+3 and 4+5
                     (card2.CardNumber == card4.CardNumber) && (card3.CardNumber == card5.CardNumber) || // 2+4 and 3+5
                     (card2.CardNumber == card5.CardNumber) && (card3.CardNumber == card4.CardNumber))   // 2+5 and 3+4
            {
                // two pairs - 5:1 
                betMoney *= 5;
                money += betMoney;
                txtMoney.Text = "$" + money;
                txtWinAmount.Content = "You won $" + betMoney + "!";
                txtWinAmount.Visibility = Visibility.Visible;
            }
            else if (card1.CardNumber == card2.CardNumber || card1.CardNumber == card3.CardNumber || card1.CardNumber == card4.CardNumber || card1.CardNumber == card5.CardNumber ||
                card2.CardNumber == card3.CardNumber || card2.CardNumber == card4.CardNumber || card2.CardNumber == card5.CardNumber ||
                card3.CardNumber == card4.CardNumber || card3.CardNumber == card5.CardNumber || card4.CardNumber == card5.CardNumber)
            {
                // pair - 1:1
                money += betMoney;
                txtMoney.Text = "$" + money;
                txtWinAmount.Content = "You won $" + betMoney + "!";
                txtWinAmount.Visibility = Visibility.Visible;
            }
            else
            {
                txtWinAmount.Content = "You lost $" + betMoney + "!";
                txtWinAmount.Visibility = Visibility.Visible;
            }
        }

        private void SetCardButtonImage(Button button, Cards card)
        {
            string cardImageURL = deck.DisplayCard(card);

            BitmapImage bitimg = new BitmapImage();
            bitimg.BeginInit();
            bitimg.UriSource = new Uri(cardImageURL, UriKind.RelativeOrAbsolute);
            bitimg.EndInit();

            Image img = new Image();
            img.Stretch = Stretch.Fill;
            img.Source = bitimg;

            // Set Button.Content
            button.Content = img;

            // Set Button.Background
            button.Background = new ImageBrush(bitimg);
        }

        private void ResetCardButtonImage(Button button)
        {
            BitmapImage bitimg = new BitmapImage();
            bitimg.BeginInit();
            bitimg.UriSource = new Uri("/Assets/Blackjack/Cards/cardBack_blue1.png", UriKind.RelativeOrAbsolute);
            bitimg.EndInit();

            Image img = new Image();
            img.Stretch = Stretch.Fill;
            img.Source = bitimg;

            // Set Button.Content
            button.Content = img;

            // Set Button.Background
            button.Background = new ImageBrush(bitimg);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) // goes back to the game menu and closes this window 
        {
            GameSelection gameSelection = new GameSelection(money, bank);
            gameSelection.Show();
            this.Close();
        }

        private void btnRules_Click(object sender, RoutedEventArgs e) // shows the game rules in a popup window 
        {
            MessageBox.Show("- Click Chips to Place Bets\n" +
                "- Click Draw Button\n" +
                "- Choose Which Cards to Keep\n" +
                "- Click Draw Button Again to Get New Cards\n" +
                "- Claim Winnings Based On Cards Drawn\n\n" +
                "- Click Reset to Play Again or Exit\n", 
                "Poker Rules");
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e) // places bet and draws cards 
        {
            if (betMoney == 0) MessageBox.Show("Place a bet first."); 
            else
            {
                if (gameSet == true)
                {
                    // if firstDraw is false, then draw cards and disable back button and set firstDraw to true 
                    if (firstDraw == false)
                    {
                        btnReset.IsEnabled = false;
                        btnBack.IsEnabled = false; 

                        // disable bet buttons 
                        btnChip1.IsEnabled = false; 
                        btnChip5.IsEnabled = false; 
                        btnChip10.IsEnabled = false; 
                        btnChip20.IsEnabled = false; 
                        btnChip50.IsEnabled = false; 
                        btnChip100.IsEnabled = false; 
                        btnChip1K.IsEnabled = false; 

                        // enable hold buttons
                        btnHold1.IsEnabled = true;
                        btnHold2.IsEnabled = true;
                        btnHold3.IsEnabled = true;
                        btnHold4.IsEnabled = true;
                        btnHold5.IsEnabled = true;

                        deck.Shuffle();
                        btnBack.IsEnabled = false;

                        // draw cards 
                        card1 = deck.TakeCard();
                        card2 = deck.TakeCard();
                        card3 = deck.TakeCard();
                        card4 = deck.TakeCard();
                        card5 = deck.TakeCard();

                        SetCardButtonImage(btnHold1, card1);
                        SetCardButtonImage(btnHold2, card2);
                        SetCardButtonImage(btnHold3, card3);
                        SetCardButtonImage(btnHold4, card4);
                        SetCardButtonImage(btnHold5, card5);

                        firstDraw = true;
                    }

                    // if firstDraw is true, redraw cards for ones not held and check wins and set firstDraw to false
                    else
                    {
                        btnReset.IsEnabled = true;
                        btnBack.IsEnabled = true; 

                        // disable hold cards
                        btnHold1.IsEnabled = false;
                        btnHold2.IsEnabled = false;
                        btnHold3.IsEnabled = false;
                        btnHold4.IsEnabled = false;
                        btnHold5.IsEnabled = false;

                        btnBack.IsEnabled = true;

                        // hold cards 
                        if (card1.isHeld == false)
                        {
                            card1 = deck.TakeCard();
                            SetCardButtonImage(btnHold1, card1);
                        }
                        if (card2.isHeld == false)
                        {
                            card2 = deck.TakeCard();
                            SetCardButtonImage(btnHold2, card2);
                        }
                        if (card3.isHeld == false)
                        {
                            card3 = deck.TakeCard();
                            SetCardButtonImage(btnHold3, card3);
                        }
                        if (card4.isHeld == false)
                        {
                            card4 = deck.TakeCard();
                            SetCardButtonImage(btnHold4, card4);
                        }
                        if (card5.isHeld == false)
                        {
                            card5 = deck.TakeCard();
                            SetCardButtonImage(btnHold5, card5);
                        }

                        CheckWin();
                        firstDraw = false;
                        gameSet = false;
                    }
                }
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e) // reset game 
        {
            // reset deck 
            deck.Reset();
            deck.Shuffle();

            // enable bet buttons 
            btnChip1.IsEnabled = true;
            btnChip5.IsEnabled = true;
            btnChip10.IsEnabled = true;
            btnChip20.IsEnabled = true;
            btnChip50.IsEnabled = true;
            btnChip100.IsEnabled = true;
            btnChip1K.IsEnabled = true;

            // disable hold cards
            btnHold1.IsEnabled = false;
            btnHold2.IsEnabled = false;
            btnHold3.IsEnabled = false;
            btnHold4.IsEnabled = false;
            btnHold5.IsEnabled = false;

            // cards not held
            if (card1 != null)
            {
                card1.isHeld = false;
                card2.isHeld = false;
                card3.isHeld = false;
                card4.isHeld = false;
                card5.isHeld = false;
            }

            // hold word not visible 
            lblHold1.Visibility = Visibility.Hidden;
            lblHold2.Visibility = Visibility.Hidden;
            lblHold3.Visibility = Visibility.Hidden;
            lblHold4.Visibility = Visibility.Hidden;
            lblHold5.Visibility = Visibility.Hidden;

            // cards picture set back to card back
            ResetCardButtonImage(btnHold1);
            ResetCardButtonImage(btnHold2);
            ResetCardButtonImage(btnHold3);
            ResetCardButtonImage(btnHold4);
            ResetCardButtonImage(btnHold5);

            txtWinAmount.Visibility = Visibility.Hidden;

            betMoney = 0;
            txtBetAmount.Text = "$0"; 
            betAmount = "";
            gameSet = true;
        }

        // Chips Buttons
        private void btnChip1_Click(object sender, RoutedEventArgs e)
        {
            if (money >= 1)
            {
                betMoney += 1;
                money -= 1;

                btnReset.IsEnabled = false;
                btnBack.IsEnabled = false;
            }
            else MessageBox.Show("Not Enough Money");

            betAmount = "$" + betMoney;
            txtBetAmount.Text = betAmount;
            txtMoney.Text = "$" + money;
        }

        private void btnChip5_Click(object sender, RoutedEventArgs e)
        {
            if (money >= 5)
            {
                betMoney += 5;
                money -= 5;

                btnReset.IsEnabled = false;
                btnBack.IsEnabled = false;
            }
            else MessageBox.Show("Not Enough Money");

            betAmount = "$" + betMoney;
            txtBetAmount.Text = betAmount;
            txtMoney.Text = "$" + money;
        }

        private void btnChip10_Click(object sender, RoutedEventArgs e)
        {
            if (money >= 10)
            {
                betMoney += 10;
                money -= 10;

                btnReset.IsEnabled = false;
                btnBack.IsEnabled = false;
            }
            else MessageBox.Show("Not Enough Money");

            betAmount = "$" + betMoney;
            txtBetAmount.Text = betAmount;
            txtMoney.Text = "$" + money;
        }

        private void btnChip20_Click(object sender, RoutedEventArgs e)
        {
            if (money >= 20)
            {
                betMoney += 20;
                money -= 20;

                btnReset.IsEnabled = false;
                btnBack.IsEnabled = false;
            }
            else MessageBox.Show("Not Enough Money");

            betAmount = "$" + betMoney;
            txtBetAmount.Text = betAmount;
            txtMoney.Text = "$" + money;
        }

        private void btnChip50_Click(object sender, RoutedEventArgs e)
        {
            if (money >= 50)
            {
                betMoney += 50;
                money -= 50;

                btnReset.IsEnabled = false;
                btnBack.IsEnabled = false;
            }
            else MessageBox.Show("Not Enough Money");

            betAmount = "$" + betMoney;
            txtBetAmount.Text = betAmount;
            txtMoney.Text = "$" + money;
        }

        private void btnChip100_Click(object sender, RoutedEventArgs e)
        {
            if (money >= 100)
            {
                betMoney += 100;
                money -= 100;

                btnReset.IsEnabled = false;
                btnBack.IsEnabled = false;
            }
            else MessageBox.Show("Not Enough Money");

            betAmount = "$" + betMoney;
            txtBetAmount.Text = betAmount;
            txtMoney.Text = "$" + money;
        }

        private void btnChip1K_Click(object sender, RoutedEventArgs e)
        {
            if (money >= 1000)
            {
                betMoney += 1000;
                money -= 1000;

                btnReset.IsEnabled = false;
                btnBack.IsEnabled = false;
            }
            else MessageBox.Show("Not Enough Money");

            betAmount = "$" + betMoney;
            txtBetAmount.Text = betAmount;
            txtMoney.Text = "$" + money;
        }

        // Hold Cards
        private void btnHold1_Click(object sender, RoutedEventArgs e)
        {
            if (lblHold1.Visibility == Visibility.Hidden) // if hidden (not held) then make visible and hold card
            {
                lblHold1.Visibility = Visibility.Visible;
                card1.isHeld = true;
            }
            else
            {
                card1.isHeld = false;
                lblHold1.Visibility = Visibility.Hidden;
            }
        }

        private void btnHold2_Click(object sender, RoutedEventArgs e)
        {
            if (lblHold2.Visibility == Visibility.Hidden)
            {
                card2.isHeld = true;
                lblHold2.Visibility = Visibility.Visible;
            }
            else
            {
                card2.isHeld = false; 
                lblHold2.Visibility = Visibility.Hidden;
            }
        }

        private void btnHold3_Click(object sender, RoutedEventArgs e)
        {
            if (lblHold3.Visibility == Visibility.Hidden)
            {
                card3.isHeld = true; 
                lblHold3.Visibility = Visibility.Visible;
            }
            else
            {
                card3.isHeld = false; 
                lblHold3.Visibility = Visibility.Hidden;
            }
        }

        private void btnHold4_Click(object sender, RoutedEventArgs e)
        {
            if (lblHold4.Visibility == Visibility.Hidden)
            {
                card4.isHeld = true; 
                lblHold4.Visibility = Visibility.Visible;
            }
            else
            {
                card4.isHeld = false;
                lblHold4.Visibility = Visibility.Hidden;
            }
        }

        private void btnHold5_Click(object sender, RoutedEventArgs e)
        {
            if (lblHold5.Visibility == Visibility.Hidden)
            {
                card5.isHeld = true; 
                lblHold5.Visibility = Visibility.Visible;
            }
            else
            {
                card5.isHeld = false; 
                lblHold5.Visibility = Visibility.Hidden;
            }
        }
    }
}
