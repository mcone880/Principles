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

        public Roulette(int money)
        {
            this.money = money;
            InitializeComponent();
            Currency.Content = "Amount: " + money.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {

            GameSelection game = new GameSelection(money);
            game.Show();
            this.Close();
        }

        private void Button_Spin(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            switch (random.Next(0 , 36))
            {
                default:
                    break;
            }
        }

        private void Button_Bet(object sender, RoutedEventArgs e)
        {

        }
    }
}
