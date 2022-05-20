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
        int chipAmount = 1000;
        int bankAmount; //Do not alter or Change, This is so that we can keep track of our Bank Amount ~ Tommy
        public GameSelection(int money)
        {
            bankAmount = money;
            InitializeComponent();
            BankAmountLabel.Content = "Chips: $0";
        }

        public GameSelection(int chips, int bankAmount)
        {
            this.bankAmount = bankAmount;
            chipAmount = chips;
            InitializeComponent();
            BankAmountLabel.Content = "Chips: $" + chips;
        }

        private void PlayRoulette_Click(object sender, RoutedEventArgs e)
        {
            Roulette newWindow = new Roulette(chipAmount, bankAmount);
            newWindow.Show();
            this.Close();
        }

        private void PlayBlackJack_Click(object sender, RoutedEventArgs e)
        {
            Blackjack newWindow = new Blackjack(chipAmount, bankAmount);
            newWindow.Show();
            this.Close();
        }

        private void PlayPoker_Click(object sender, RoutedEventArgs e)
        {
            Poker newWindow = new Poker(chipAmount, bankAmount);
            newWindow.Show();
            this.Close();
        }

        private void PlayCraps_Click(object sender, RoutedEventArgs e)
        {
            Craps newWindow = new Craps(chipAmount, bankAmount);
            newWindow.Show();
            this.Close();
        }

        private void PlaySlots_Click(object sender, RoutedEventArgs e)
        {
            Slots newWindow = new Slots(chipAmount, bankAmount);
            newWindow.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            newWindow.Show();
            this.Close();
        }

        private void BankButton_Click(object sender, RoutedEventArgs e)
        {
            Bank bank = new Bank(chipAmount, bankAmount);
            bank.Show();
            this.Close();
        }
    }
}
