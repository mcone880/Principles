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

        public Blackjack(int money)
        {
            InitializeComponent();
            this.money = money;

            Money.Content = "$ " + money;
        }

        //Go Back to Game Selection
        private void BackClicked(object sender, RoutedEventArgs e)
        {
            GameSelection gameSelection = new GameSelection(money);
            gameSelection.Show();

            this.Close();
        }

        //Show Rules
        private void RulesClicked(object sender, RoutedEventArgs e)
        {
            string message = "\t Objective: \n Win money by having the closest card total to 21, but nothing over 21. \n \t Hit: \n Take a card, up to 5 cards \n \t Stand: \n End turn \n \n Face Cards count as 10 whil Ace is 1";
            MessageBox.Show(message, "Blackjack Rules");
        }
    }
}
