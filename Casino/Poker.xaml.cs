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
        string betAmount;// = "$";
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

        private void CheckWin() // need to do this 
        {
            MessageBox.Show("Made it to the win check! Unfortunately, I have not yet made the win check.");
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
            if (gameSet == true)
            {
                // bet stuff 

                // if firstDraw is false, then draw cards and disable back button and set firstDraw to true 
                if (firstDraw == false)
                {
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

        private void btnReset_Click(object sender, RoutedEventArgs e) // reset game 
        {
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

            betMoney = 0;
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
