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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pente
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TitleWindow.Width = 815;
            TitleWindow.Height = 475;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            string p1Name = playerOne.Text.ToString();
            string p1Color = P1color.Text.ToString();
            string p2Name = playerTwo.Text.ToString();
            string p2Color = P2color.Text.ToString();

            if (p1Name == "") p1Name = "Player 1";
            if (p1Color == "") p1Color = "White";
            if (p2Name == "") p2Name = "Player 2";
            if (p2Color == "") p2Color = "Black";
            if (p1Name.Equals(p2Name))  
            {
                MessageBox.Show("You can't choose the same name. Please choose a different name.", "Name Error");
                return;
            }
            if (p1Color.Equals(p2Color))
            {
                MessageBox.Show("You can't choose the same color. The default for player 1 is white, the default for player 2 is black.", "Color Problem");
                return;
            }

            Game game = new Game(p1Name, p2Name, p1Color, p2Color);
            game.Show();
            Close();
        }

        private void btnRules_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HOW TO PLAY:\n Start with the board completely clear of stones. The first player(chosen by chance) begins the game by playing one stone on the center point. Thereafter the players take turns playing their stones, one at a time, on any empty intersection.The stones are played on the intersections of the lines(including the edge of the board), rather than in the squares. " +
                "A move is completed when the stone is released. Once played, a stone cannot be moved again(except when re­moved by a capture, as is explained below)." +
                "The players simply take turns adding new stones to the board, building up the position, until one person wins as follows:\n\n" +
                "OBJECT OF THE GAME:\n" +
                "There are two ways to win in Pente. Win by getting five(or more) stones in a row, either horizontally, vertically, or diagonally, " +
                "with no empty points between them. Win by capturing five pairs(or more) of the opponent's stones. The first player to achieve either " +
                "of the above objectives wins the game.", "Rules");
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
