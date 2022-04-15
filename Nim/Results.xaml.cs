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
        int player1Score = 0;
        int player2Score = 0;
        Difficulty difficulty;
        Name names;

        public Results(Name names, string winner, Difficulty difficulty)
        {
            InitializeComponent();
            Player1Label.Content = names.playerOne;
            Player2Label.Content = names.playerTwo;
            this.difficulty = difficulty;
            this.names = names;
            if ((string)Player1Label.Content == winner) player1Score++;
            else player2Score++;
            updateScores();
        }

        private void updateScores()
        {
            Player1ScoreLabel.Content = player1Score;
            Player2ScoreLabel.Content = player2Score;
        }

        private void RematchButton_Click(object sender, RoutedEventArgs e)
        {
            //Start up a brand new game
            Game newWindow = new Game(difficulty, names);
            newWindow.Show();
            this.Hide();
        }

        private void StartOverButton_Click(object sender, RoutedEventArgs e)
        {
            Name newWindow = new Name();
            newWindow.Show();
            this.Close();
        }
    }
}
