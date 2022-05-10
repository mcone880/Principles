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
        public Poker(int money)
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) // goes back to the game menu and closes this window 
        {
            GameSelection gameSelection = new GameSelection();
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
    }
}
