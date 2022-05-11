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
    /// Interaction logic for GameSelection.xaml
    /// </summary>
    public partial class GameSelection : Window
    {
        int bankAmount;
        public GameSelection(int money)
        {
            bankAmount = money;
            InitializeComponent();
        }

        private void PlayRoulette_Click(object sender, RoutedEventArgs e)
        {
            Roulette newWindow = new Roulette(bankAmount);
            newWindow.Show();
            this.Close();
        }

        private void PlayBlackJack_Click(object sender, RoutedEventArgs e)
        {
            Blackjack newWindow = new Blackjack(bankAmount);
            newWindow.Show();
            this.Close();
        }

        private void PlayPoker_Click(object sender, RoutedEventArgs e)
        {
            Poker newWindow = new Poker(bankAmount);
            newWindow.Show();
            this.Close();
        }

        private void PlayCraps_Click(object sender, RoutedEventArgs e)
        {
            Craps newWindow = new Craps(bankAmount);
            newWindow.Show();
            this.Close();
        }

        private void PlaySlots_Click(object sender, RoutedEventArgs e)
        {
            Slots newWindow = new Slots(bankAmount);
            newWindow.Show();
            this.Close();
        }
    }
}
