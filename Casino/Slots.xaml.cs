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
    /// Interaction logic for Slots.xaml
    /// </summary>
    public partial class Slots : Window
    {
        public string[] options = new string[]{ "Cherry", "Cherry", "Cherry", "Cherry", "Bells", "Bells", "Bells", "Bars", "Bars", "Sevens" };
        int money;
        int bank;
        bool betPlaysted;
        
        int bet;
        String SlotOne;
        String SlotTwo;
        String SlotThree;

        public Slots(int money, int bank)
        {
            InitializeComponent();
            this.money = money;
            this.bank = bank;

            txtMoney.Text ="$ "+ money.ToString();
        }

        private void checkForWin()
        {
            /*Cherry(4 in 10 per Wheel) - 15:1
              Bells(3 in 10 per Wheel) - 35:1
              Bars(2 in 10 per Wheel) - 100:1
              Sevens(1 in 10 per Wheel) - 1000:1*/
            if (SlotOne == SlotTwo && SlotOne == SlotThree)
            {
                if(SlotOne== "Cherry")
                {
                    bet = (bet * 15) + bet;
                }
                if(SlotOne== "Bells")
                {
                    bet = (bet * 35) + bet;

                }
                if (SlotOne== "Bars")
                {
                    bet = (bet * 100) + bet;

                }
                if (SlotOne== "Sevens")
                {
                    bet = (bet * 1000) + bet;

                }

            }
            else
            {
                ResultBet.Text = "- $ " + bet;
                ResultBet.Foreground = Brushes.Red;
                bet = 0;
            }
            Bet.Text = "$ 0";
            if(bet> 0)
            {
                Result.Text = "Winner";
                ResultBet.Text = " + $" + bet;
                ResultBet.Foreground = Brushes.Green;
                if(bet> 100)
                {
                    ResultBet.FontSize = 24;
                }
                if (bet > 1000)
                {
                    ResultBet.FontSize = 20;
                }
            }
            else
            {
                Result.Text = "Loser";
            }
            Payout(bet);
            bet = 0;

            
        }
        public void Payout(int payout)
        {
            //add to the balance
            money += payout;
            txtMoney.Text = money.ToString();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e) // goes back to the game menu and closes this window 
        {
            GameSelection gameSelection = new GameSelection(money, bank);
            gameSelection.Show();
            this.Close();
        }


        private void Spin_Click(object sender, RoutedEventArgs e)
        {
            SlotOne = getRandomImage();
            SlotTwo = getRandomImage();
            SlotThree = getRandomImage();

            ImageBrush I1R = (ImageBrush)Resources[SlotOne];
            ImageBrush I2R = (ImageBrush)Resources[SlotTwo];
            ImageBrush I3R = (ImageBrush)Resources[SlotThree];

            I1.Source = I1R.ImageSource;
            I2.Source = I2R.ImageSource;
            I3.Source = I3R.ImageSource;
            

            /*Cherry(4 in 10 per Wheel) - 15:1
              Bells(3 in 10 per Wheel) - 35:1
              Bars(2 in 10 per Wheel) - 100:1
              Sevens(1 in 10 per Wheel) - 1000:1*/

            betPlaysted = false;
            btnBack.IsEnabled = true;
            Spin.IsEnabled = false;

            checkForWin();
        }

        private String getRandomImage()
        {
            Random r = new Random();
            int i= r.Next(1, 10);
            string s = options[i];
            return s;
        }

        private void btnChip1_Click(object sender, RoutedEventArgs e)
        {
            if(money< 1) { return; }
            betPlaysted = true;
            btnBack.IsEnabled = false;
            Spin.IsEnabled = true;
            SetBet(1);

        }
        private void btnChip5_Click(object sender, RoutedEventArgs e)
        {
            if (money < 5) { return; }

            betPlaysted = true;
            btnBack.IsEnabled = false;
            Spin.IsEnabled = true;
            SetBet(5);

        }
        private void btnChip10_Click(object sender, RoutedEventArgs e)
        {
            if (money < 10) { return; }

            betPlaysted = true;
            btnBack.IsEnabled = false;
            Spin.IsEnabled = true;
            SetBet(10);

        }
        private void btnChip20_Click(object sender, RoutedEventArgs e)
        {
            if (money < 20) { return; }

            betPlaysted = true;
            btnBack.IsEnabled = false;
            Spin.IsEnabled = true;
            SetBet(20);
        }


        private void btnChip50_Click(object sender, RoutedEventArgs e)
        {
            if (money < 50) { return; }

            betPlaysted = true;
            btnBack.IsEnabled = false;
            Spin.IsEnabled = true;
            SetBet(50);

        }
        private void btnChip100_Click(object sender, RoutedEventArgs e)
        {
            if (money < 100) { return; }

            betPlaysted = true;
            btnBack.IsEnabled = false;
            Spin.IsEnabled = true;
            SetBet(100);

        }
        private void btnChip1k_Click(object sender, RoutedEventArgs e)
        {
            if (money < 1000) { return; }

            betPlaysted = true;
            btnBack.IsEnabled = false;
            Spin.IsEnabled = true;
            SetBet(1000);

        }
        private void SetBet(int v)
        {
            Result.Text = "";
            ResultBet.Text = "";
            if(v<= money && money != 0)
            {
                bet += v;
                Bet.Text = "$ " +  bet.ToString();
                money = money - v;
                txtMoney.Text = money.ToString();
            }
        }


    }
}
