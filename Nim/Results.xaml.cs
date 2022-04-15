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

        public Results(string p1, string p2, string winner, Difficulty d)
        {
            InitializeComponent();
            Player1Label.Content = p1;
            Player2Label.Content = p2;
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
        }

        private void StartOverButton_Click(object sender, RoutedEventArgs e)
        {
            Name newWindow = new Name();
            newWindow.Show();
            this.Close();
        }
    }
}
