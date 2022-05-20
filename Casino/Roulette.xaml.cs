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
        public int bank; //Do not alter or Change, This is so that we can keep track of our Bank Amount ~ Tommy
        public int numbers = 0;
        public string color = "";
        public int bettingPool = 0;
        
        private int one = 0;
        private string onestr = "1";
        private int two = 0;
        private string twoStr = "2";
        private int three = 0;
        private string threeStr = "3";
        private int four = 0;
        private string fourStr = "4";
        private int five = 0;
        private string fiveStr = "5";
        private int six = 0;
        private string sixStr = "6";
        private int seven = 0;
        private string sevenStr = "7";
        private int eight = 0;
        private string eightStr = "8";
        private int nine = 0;
        private string nineStr = "9";
        private int ten = 0;
        private string tenStr = "10";
        private int eleven = 0;
        private string elevenStr = "11";
        private int twelve = 0;
        private string twelveStr = "12";
        private int thirteen = 0;
        private string thirteenStr = "13";
        private int fourteen = 0;
        private string fourteenStr = "14";
        private int fifteen = 0;
        private string fifteenStr = "15";
        private int sixteen = 0;
        private string sixteenStr = "16";
        private int seventeen = 0;
        private string seventeenStr = "17";
        private int eighteen = 0;
        private string eighteenStr = "18";
        private int nineteen = 0;
        private string nineteenStr = "19";
        private int twenty = 0;
        private string twentyStr = "20";
        private int twentyOne = 0;
        private string twentyOneStr = "21";
        private int twentyTwo = 0;
        private string twentyTwoStr = "22";
        private int twentyThree = 0;
        private string twentyThreeStr = "23";
        private int twentyFour = 0;
        private string twentyFourStr = "24";
        private int twentyFive = 0;
        private string twentyFiveStr = "25";
        private int twentySix = 0;
        private string twentySixStr = "26";
        private int twentySeven = 0;
        private string twentySevenStr = "27";
        private int twentyEight = 0;
        private string twetyEightStr = "28";
        private int twentyNine = 0;
        private string twentyNineStr = "29";
        private int thirty = 0;
        private string thirtyStr = "30";
        private int thirtyOne = 0;
        private string thirtyOneStr = "31";
        private int thirtyTwo = 0;
        private string thirtyTwoStr = "32";
        private int thirtyThree = 0;
        private string thirtyThreeStr = "33";
        private int thirtyFour = 0;
        private string thirtyFourStr = "34";
        private int thirtyFive = 0; 
        private string thirtyFiveStr = "35";
        private int thirtySix = 0;
        private string thirtySixStr = "36";
        private int zero = 0;
        private string zeroStr = "0";
        private int red = 0;
        private string redStr = "Red";
        private int black = 0;
        private string blackStr = "Black";
        private int column1 = 0;
        private string column1Str = "col1";
        private int column2 = 0;
        private string column2Str = "col2";
        private int column3 = 0;
        private string column3Str = "col3";
        private int first12 = 0;
        private string first12Str = "1st 12";
        private int second12 = 0;
        private string second12Str = "2nd 12";
        private int third12 = 0;
        private string third12Str = "3rd 12";
        private int firstHalf = 0;
        private string firstHalfStr = "1-18";
        private int secondHalf = 0;
        private string secondHalfStr = "19-36";
        private int odd = 0;
        private string oddStr = "Odd";
        private int even = 0;
        private string evenStr = "Even";


        public Roulette(int money, int bank)
        {
            this.money = money;
            this.bank = bank;
            InitializeComponent();
            Currency.Content = "Amount: $" + money.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            //Roulette board;
            if (money > 0)
            {
                if (onestr.Equals(btn.Content.ToString()))
                {
                    one += bettingPool;
                    money -= bettingPool;
                }
                if (twoStr.Equals(btn.Content.ToString()))
                {
                    two += bettingPool;
                    money -= bettingPool;
                }
                if (threeStr.Equals(btn.Content.ToString()))
                {
                    three += bettingPool;
                    money -= bettingPool;
                }
                if (fourStr.Equals(btn.Content.ToString()))
                {
                    four += bettingPool;
                    money -= bettingPool;
                }
                if (fiveStr.Equals(btn.Content.ToString()))
                {
                    five += bettingPool;
                    money -= bettingPool;
                }
                if (sixStr.Equals(btn.Content.ToString()))
                {
                    six += bettingPool;
                    money -= bettingPool;
                }
                if (sevenStr.Equals(btn.Content.ToString()))
                {
                    seven += bettingPool;
                    money -= bettingPool;
                }
                if (eightStr.Equals(btn.Content.ToString()))
                {
                    eight += bettingPool;
                    money -= bettingPool;
                }
                if (nineStr.Equals(btn.Content.ToString()))
                {
                    nine += bettingPool;
                    money -= bettingPool;
                }
                if (tenStr.Equals(btn.Content.ToString()))
                {
                    ten += bettingPool;
                    money -= bettingPool;
                }
                if (elevenStr.Equals(btn.Content.ToString()))
                {
                    eleven += bettingPool;
                    money -= bettingPool;
                }
                if (twelveStr.Equals(btn.Content.ToString()))
                {
                    twelve += bettingPool;
                    money -= bettingPool;
                }
                if (thirteenStr.Equals(btn.Content.ToString()))
                {
                    thirteen += bettingPool;
                    money -= bettingPool;
                }
                if (fourteenStr.Equals(btn.Content.ToString()))
                {
                    fourteen += bettingPool;
                    money -= bettingPool;
                }
                if (fifteenStr.Equals(btn.Content.ToString()))
                {
                    fifteen += bettingPool;
                    money -= bettingPool;
                }
                if (sixteenStr.Equals(btn.Content.ToString()))
                {
                    sixteen += bettingPool;
                    money -= bettingPool;
                }
                if (seventeenStr.Equals(btn.Content.ToString()))
                {
                    seventeen += bettingPool;
                    money -= bettingPool;
                }
                if (eighteenStr.Equals(btn.Content.ToString()))
                {
                    eighteen += bettingPool;
                    money -= bettingPool;
                }
                if (nineteenStr.Equals(btn.Content.ToString()))
                {
                    nineteen += bettingPool;
                    money -= bettingPool;
                }
                if (twentyStr.Equals(btn.Content.ToString()))
                {
                    twenty += bettingPool;
                    money -= bettingPool;
                }
                if (twentyOneStr.Equals(btn.Content.ToString()))
                {
                    twentyOne += bettingPool;
                    money -= bettingPool;
                }
                if (twentyTwoStr.Equals(btn.Content.ToString()))
                {
                    twentyTwo += bettingPool;
                    money -= bettingPool;
                }
                if (twentyThreeStr.Equals(btn.Content.ToString()))
                {
                    twentyThree += bettingPool;
                    money -= bettingPool;
                }
                if (twentyFourStr.Equals(btn.Content.ToString()))
                {
                    twentyFour += bettingPool;
                    money -= bettingPool;
                }
                if (twentyFiveStr.Equals(btn.Content.ToString()))
                {
                    twentyFive += bettingPool;
                    money -= bettingPool;
                }
                if (twentySixStr.Equals(btn.Content.ToString()))
                {
                    twentySix += bettingPool;
                    money -= bettingPool;
                }
                if (twentySevenStr.Equals(btn.Content.ToString()))
                {
                    twentySeven += bettingPool;
                    money -= bettingPool;
                }
                if (twentyEight.Equals(btn.Content.ToString()))
                {
                    twentyEight += bettingPool;
                    money -= bettingPool;
                }
                if (twentyNineStr.Equals(btn.Content.ToString()))
                {
                    twentyNine += bettingPool;
                    money -= bettingPool;
                }
                if (thirtyStr.Equals(btn.Content.ToString()))
                {
                    thirty += bettingPool;
                    money -= bettingPool;
                }
                if (thirtyOneStr.Equals(btn.Content.ToString()))
                {
                    thirtyOne += bettingPool;
                    money -= bettingPool;
                }
                if (thirtyTwoStr.Equals(btn.Content.ToString()))
                {
                    thirtyTwo += bettingPool;
                    money -= bettingPool;
                }
                if (thirtyThreeStr.Equals(btn.Content.ToString()))
                {
                    thirtyThree += bettingPool;
                    money -= bettingPool;
                }
                if (thirtyFourStr.Equals(btn.Content.ToString()))
                {
                    thirtyFour += bettingPool;
                    money -= bettingPool;
                }
                if (thirtyFiveStr.Equals(btn.Content.ToString()))
                {
                    thirtyFive += bettingPool;
                    money -= bettingPool;
                }
                if (thirtySixStr.Equals(btn.Content.ToString()))
                {
                    thirtySix += bettingPool;
                    money -= bettingPool;
                }
                if (zeroStr.Equals(btn.Content.ToString()))
                {
                    zero += bettingPool;
                    money -= bettingPool;
                }
                if (redStr.Equals(btn.Content.ToString()))
                {
                    red += bettingPool;
                    money -= bettingPool;
                }
                if (blackStr.Equals(btn.Content.ToString()))
                {
                    black += bettingPool;
                    money -= bettingPool;
                }
                if (column1Str.Equals(btn.Content.ToString()))
                {
                    column1 += bettingPool;
                    money -= bettingPool;
                }
                if (column2Str.Equals(btn.Content.ToString()))
                {
                    column2 += bettingPool;
                    money -= bettingPool;
                }
                if (column3Str.Equals(btn.Content.ToString()))
                {
                    column3 += bettingPool;
                    money -= bettingPool;
                }
                if (first12Str.Equals(btn.Content.ToString()))
                {
                    first12Str += bettingPool;
                    money -= bettingPool;
                }
                if (second12Str.Equals(btn.Content.ToString()))
                {
                    second12Str += bettingPool;
                    money -= bettingPool;
                }
                if (third12Str.Equals(btn.Content.ToString()))
                {
                    third12Str += bettingPool;
                    money -= bettingPool;
                }
                if (firstHalfStr.Equals(btn.Content.ToString()))
                {
                    firstHalf += bettingPool;
                    money -= bettingPool;
                }
                if (secondHalfStr.Equals(btn.Content.ToString()))
                {
                    secondHalf += bettingPool;
                    money -= bettingPool;
                }
                if (oddStr.Equals(btn.Content.ToString()))
                {
                    odd += bettingPool;
                    money -= bettingPool;
                }
                if (evenStr.Equals(btn.Content.ToString()))
                {
                    even += bettingPool;
                    money -= bettingPool;
                }
            }
            else
            {
                Results.Text = "No money!!!!";
            }
            Currency.Content = "Amount: $" + money.ToString();

        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            GameSelection game = new GameSelection(money, bank);
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
                BettingAmount.Content = "Betting: $" + bettingPool.ToString();
            }
            else
            {
                Results.Text = "No money!!!!";
            }
        }
    }
}
