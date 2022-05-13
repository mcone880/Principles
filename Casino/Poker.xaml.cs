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

        public Poker(int money)
        {
            InitializeComponent();
            this.money = money;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) // goes back to the game menu and closes this window 
        {
            GameSelection gameSelection = new GameSelection(money);
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
                "- Play Again or Exit\n", 
                "Poker Rules");
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e) // places bet and draws cards 
        {

        }


        // Chips Buttons
        private void btnChip1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChip5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChip10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChip20_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChip50_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChip100_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChip1K_Click(object sender, RoutedEventArgs e)
        {

        }

        // Hold Cards
        private void btnHold1_Click(object sender, RoutedEventArgs e)
        {
            if (lblHold1.Visibility == Visibility.Hidden) lblHold1.Visibility = Visibility.Visible;
            else lblHold1.Visibility = Visibility.Hidden;

        }

        private void btnHold2_Click(object sender, RoutedEventArgs e)
        {
            if (lblHold2.Visibility == Visibility.Hidden) lblHold2.Visibility = Visibility.Visible;
            else lblHold2.Visibility = Visibility.Hidden;

        }

        private void btnHold3_Click(object sender, RoutedEventArgs e)
        {
            if (lblHold3.Visibility == Visibility.Hidden) lblHold3.Visibility = Visibility.Visible;
            else lblHold3.Visibility = Visibility.Hidden;
        }

        private void btnHold4_Click(object sender, RoutedEventArgs e)
        {
            if (lblHold4.Visibility == Visibility.Hidden) lblHold4.Visibility = Visibility.Visible;
            else lblHold4.Visibility = Visibility.Hidden;
        }

        private void btnHold5_Click(object sender, RoutedEventArgs e)
        {
            if (lblHold5.Visibility == Visibility.Hidden) lblHold5.Visibility = Visibility.Visible;
            else lblHold5.Visibility = Visibility.Hidden;
        }
    }
}
