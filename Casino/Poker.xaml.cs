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
            MessageBox.Show("Poker Rules", "Poker Rules");
        }

        private void btnBet_Click(object sender, RoutedEventArgs e) // places bet and draws cards 
        {

        }

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
    }
}
