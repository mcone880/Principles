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

namespace Nim
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        Game game;

        public Results(string winner, Game game)
        {
            InitializeComponent();
            PlayerWinLabel.Content = winner + " WINS";
            this.game = game;
        }


        private void RematchButton_Click(object sender, RoutedEventArgs e)
        {
            //Start up a brand new game
            Game newGame = new Game(game.difficulty, game.names);
            game.Close();
            newGame.Show();
            this.Close();
        }

        private void StartOverButton_Click(object sender, RoutedEventArgs e)
        {
            Name newWindow = new Name();
            newWindow.Show();
            game.Close();
            this.Close();
        }
    }
}
