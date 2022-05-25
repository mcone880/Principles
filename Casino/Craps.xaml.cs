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
    /// Interaction logic for Craps.xaml
    /// </summary>
    /// 

    public enum BET
    {
        TWO,
        THREE,
        SEVEN,
        ELEVEN,
        TWELVE,
        ANY,
        D_TWO,
        D_THREE,
        D_FOUR,
        D_FIVE,
        FIELD
    }

    public partial class Craps : Window
    {
        BET myBet;
        bool betPlaced = false;
        bool betChosen = false;
        int credits;
        int bank; //Do not alter or Change, This is so that we can keep track of our Bank Amount ~ Tommy
        int bet = 0;
        Image[] Images = new Image[12];
        //Button[] BetButtons = new Button[11];

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
            //BetButtons = GetBetButtons();

            //foreach(var button in BetButtons)
            //{
            //    button.IsEnabled = false;
            //}

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

        //public Button[] GetBetButtons()
        //{
        //    List<Button> buttons = new List<Button>();
        //    List<Button> betButtons = new List<Button>();

        //    foreach(var thing in MainGrid.Children)
        //    {
        //        if(thing.GetType().Equals(typeof(Button)))
        //        {
        //            buttons.Add((Button)thing);
        //        }
        //    }

        //    foreach(var button in buttons)
        //    {
        //        if (button.Tag != null && button.Tag.ToString() == "BetButton") betButtons.Add(button);
        //    }
        //    return betButtons.ToArray();
        //}

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

            switch (myBet)
            {
                case BET.TWO:
                    if (results[2] != 2) credits -= bet;
                    else credits += bet * 31;
                    break;
                case BET.THREE:
                    if (results[2] != 3) credits -= bet;
                    else credits += bet * 16;
                    break;
                case BET.SEVEN:
                    if (results[2] != 7) credits -= bet;
                    else credits += bet * 5;
                    break;
                case BET.ELEVEN:
                    if (results[2] != 11) credits -= bet;
                    else credits += bet * 16;
                    break;
                case BET.TWELVE:
                    if (results[2] != 12) credits -= bet;
                    else credits += bet * 31;
                    break;
                case BET.ANY:
                    if (results[2] != 2 || results[2] != 3 || results[2] == 12) /*2,3,12*/credits -= bet;
                    else credits += bet * 8;
                    break;
                case BET.D_TWO:
                    if (results[0] == 2 && results[1] == 2) credits += bet * 8;
                    else credits -= bet;
                    break;
                case BET.D_THREE:
                    if (results[0] == 3 && results[1] == 3) credits += bet * 9;
                    else credits -= bet;
                    break;
                case BET.D_FOUR:
                    if (results[0] == 4 && results[1] == 4) credits += bet * 9;
                    else credits -= bet;
                    break;
                case BET.D_FIVE:
                    if (results[0] == 5 && results[1] == 5) credits += bet * 8;
                    else credits -= bet;
                    break;
                case BET.FIELD:
                    if (results[2] == 5 || results[2] == 6 || results[2] == 7 || results[2] == 8) credits -= bet;
                    else if (results[2] == 2) credits += bet * 3;
                    else if (results[2] == 12) credits += bet * 4;
                    else credits += bet * 2;
                    break;
            }

            bet = 0;
            lblBet.Content = "Bet: " + bet;
            lblMoney.Content = "Money: " + credits;

            betPlaced = false;
            betChosen = false;
            RollButton.IsEnabled = false;
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
            int betAmount = bet;
            if (sender == btn1 && credits >= 1) bet += 1;
            else if (sender == btn5 && credits >= 5) bet += 5;
            else if (sender == btn10 && credits >= 10) bet += 10;
            else if (sender == btn20 && credits >= 20) bet += 20;
            else if (sender == btn50 && credits >= 50) bet += 50;
            else if (sender == btn100 && credits >= 100) bet += 100;
            else if (sender == btn1000 && credits >= 1000) bet += 1000;
            credits -= bet - betAmount;
            lblMoney.Content = "Money: " + credits;
            lblBet.Content = "Bet: " + bet;
            betPlaced = true;
            if (betPlaced && betChosen) RollButton.IsEnabled = true;
        }

        private void BetButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == Bet2 && !betChosen) myBet = BET.TWO;
            else if (sender == Bet3 && !betChosen) myBet = BET.THREE;
            else if (sender == Bet7 && !betChosen) myBet = BET.SEVEN;
            else if (sender == Bet11 && !betChosen) myBet = BET.ELEVEN;
            else if (sender == Bet12 && !betChosen) myBet = BET.TWELVE;
            else if (sender == BetAny && !betChosen) myBet = BET.ANY;
            else if (sender == BetDouble2 && !betChosen) myBet = BET.D_TWO;
            else if (sender == BetDouble3 && !betChosen) myBet = BET.D_THREE;
            else if (sender == BetDouble4 && !betChosen) myBet = BET.D_FOUR;
            else if (sender == BetDouble5 && !betChosen) myBet = BET.D_FIVE;
            else if (sender == BetField && !betChosen) myBet = BET.FIELD;

            betChosen = true;
            if (betPlaced && betChosen) RollButton.IsEnabled = true;
        }
    }
}
