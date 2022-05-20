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
    /// Interaction logic for Roulette.xaml
    /// </summary>
    public partial class Roulette : Window
    {
        public int money;
        public int numbers = 0;
        public string color = "";
        public int bettingPool = 0;
        private int one = 0;
        private int two = 0;
        private int three = 0;
        private int four = 0;
        private int five = 0;
        private int six = 0;
        private int seven = 0;
        private int eight = 0;
        private int nine = 0;
        private int ten = 0;
        private int eleven = 0;
        private int twelve = 0;
        private int thirteen = 0;
        private int fourteen = 0;
        private int fifteen = 0;
        private int sixteen = 0;
        private int seventeen = 0;
        private int eighteen = 0;
        private int nineteen = 0;
        private int twenty = 0;
        private int twentyOne = 0;
        private int twentyTwo = 0;
        private int twentyThree = 0;
        private int twentyFout = 0;
        private int twentyFive = 0;
        private int twentySix = 0;
        private int twentySeven = 0;
        private int twentyEight = 0;
        private int twentyNine = 0;
        private int thirty = 0;
        private int thirtyOne = 0;
        private int thirtyTwo = 0;
        private int thirtyThree = 0;
        private int thirtyFour = 0;
        private int thirtyFive = 0;
        private int thirtySix = 0;
        private int zero = 0;
        private int red = 0;
        private int black = 0;
        private int column1 = 0;
        private int column2 = 0;
        private int column3 = 0;
        private int first12 = 0;
        private int second12 = 0;
        private int third12 = 0;
        private int firstHalf = 0;
        private int secondHalf = 0;
        private int odd = 0;
        private int even = 0;
        
        
        public Roulette(int money)
        {
            this.money = money;
            InitializeComponent();
            Currency.Content = "Amount: " + money.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Roulette board;
            if (money > 0)
            {

            }
            else
            {
                Results.Text = "No money!!!!";
            }
            
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            GameSelection game = new GameSelection(money);
            game.Show();
            this.Close();
        }

        private void Button_Spin(object sender, RoutedEventArgs e)
        {
            if (money > 0)
            {
                //Spin and show results;
                Random random = new Random();
                switch (random.Next(0 , 36))
                {
                    case 0:
                        numbers = 0;
                        color = "Green";
                        break;
                    case 1:
                        numbers = 1;
                        color = "Red";
                        break;
                    case 2:
                        numbers = 2;
                        color = "Black";
                        break;
                    case 3:
                        numbers = 3;
                        color = "Red";
                        break;
                    case 4:
                        numbers = 4;
                        color = "Black";
                        break;
                    case 5:
                        numbers = 5;
                        color = "Red";
                        break;
                    case 6:
                        numbers = 6;
                        color = "Black";
                        break;
                    case 7:
                        numbers = 7;
                        color = "Red";
                        break;
                    case 8:
                        numbers = 8;
                        color = "Black";
                        break;
                    case 9:
                        numbers = 9;
                        color = "Red";
                        break;
                    case 10:
                        numbers = 10;
                        color = "Black";
                        break;
                    case 11:
                        numbers = 11;
                        color = "Black";
                        break;
                    case 12:
                        numbers = 12;
                        color = "Red";
                        break;
                    case 13:
                        numbers = 13;
                        color = "Black";
                        break;
                    case 14:
                        numbers = 14;
                        color = "Red";
                        break;
                    case 15:
                        numbers = 15;
                        color = "Black";
                        break;
                    case 16:
                        numbers = 16;
                        color = "Red";
                        break;
                    case 17:
                        numbers = 17;
                        color = "Black";
                        break;
                    case 18:
                        numbers = 18;
                        color = "Red";
                        break;
                    case 19:
                        numbers = 19;
                        color = "Red";
                        break;
                    case 20:
                        numbers = 20;
                        color = "Black";
                        break;
                    case 21:
                        numbers = 21;
                        color = "Red";
                        break;
                    case 22:
                        numbers = 22;
                        color = "Black";
                        break;
                    case 23:
                        numbers = 23;
                        color = "Red";
                        break;
                    case 24:
                        numbers = 24;
                        color = "Black";
                        break;
                    case 25:
                        numbers = 25;
                        color = "Red";
                        break;
                    case 26:
                        numbers = 26;
                        color = "Black";
                        break;
                    case 27:
                        numbers = 27;
                        color = "Red";
                        break;
                    case 28:
                        numbers = 28;
                        color = "Black";
                        break;
                    case 29:
                        numbers = 29;
                        color = "Black";
                        break;
                    case 30:
                        numbers = 30;
                        color = "Red";
                        break;
                    case 31:
                        numbers = 31;
                        color = "Black";
                        break;
                    case 32:
                        numbers = 32;
                        color = "Red";
                        break;
                    case 33:
                        numbers = 33;
                        color = "Black";
                        break;
                    case 34:
                        numbers = 34;
                        color = "Red";
                        break;
                    case 35:
                        numbers = 35;
                        color = "Black";
                        break;
                    case 36:
                        numbers = 36;
                        color = "Red";
                        break;
                    default:
                        break;
                }
                Results.Text = numbers + "\n" + color;

            }
            else
            {
                Results.Text = "No money!!!!";
            }
        }

        //Betting
        private void Button_Bet(object sender, RoutedEventArgs e)
        {
            if (money > 0)
            {
                //Get button to set what bet it on
                Button btn = (Button)sender;
                bettingPool = int.Parse(btn.Content.ToString());
                BettingAmount.Content = "Bet: " + bettingPool.ToString() + " Chips";
            }
            else
            {
                Results.Text = "No money!!!!";
            }
        }
    }
}
