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

namespace Pente
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public class Player 
    {
        public string name;
        public Color color;
        public int points = 0;
    } 

    public partial class Game : Window
    {
        Player p1 = new Player();
        Player p2 = new Player();
        Player currentPlayer;

        public int[,] board = new int[21 , 21];

        public Game(string p1Name, string p2Name, string p1Color, string p2Color)
        {
            p1.name = p1Name;
            p2.name = p2Name;
            switch (p1Color)
            {
                case "black":
                    p1.color = Brushes.Black.Color;
                    break;
            }
            InitializeComponent();
            //Set Player 1 has first player
            currentPlayer = p1;
            UpdateBoard();
        }
        public Game()
        {

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int row = Grid.GetRow(btn);
            int col = Grid.GetColumn(btn);
            if (btn.Background != Brushes.Gray) return;
            
            //btn.Background = currentPlayer.color;
            if(currentPlayer.name == p1.name)
            {
                board[row, col] = 1;
            }
            else
            {
                board[row, col] = 2;
            }

            currentPlayer.points += CheckSteals(board, row, col); //Needs actual values
            if(currentPlayer.points >= 10)
            {
                PlayerWins(p1, p2, currentPlayer);

            }
            else
            {
                switch (CheckVictory(board, row, col)) // Needs actual values
                {
                    case 3:
                        MessageBox.Show("Tria", "Lets Go!");
                        break;
                    case 4:
                        MessageBox.Show("Tessera", "Lets Go!");
                        break;
                    case 5:
                        PlayerWins(p1, p2, currentPlayer);
                        break;
                    default:
                        break;
                }
            }
            UpdateBoard();
            if(currentPlayer.name == p1.name)
            {
                p1 = currentPlayer;
                currentPlayer = p2;
            }
            else
            {
                p2 = currentPlayer;
                currentPlayer = p1;
            }

        }
        //button being pressed
        //set colors / button
        //check steals
        //if players steals = 10 then they win
        //check victories
        //Switch
        //Case 5: Player wins
        //Case 4: State that they have 4 in a row
        //Case 3: State that they have 3 in a row
        //disable button
        //change player


        public int CheckSteals(int[,] board, int row, int col)
        {
            //if steal
            //change the buttons
            //increment the steals of current Player
            int playerColor = board[row, col];
            int check1;
            int check2;
            int check3;
            int pointsGained = 0;

            //Check Up
            if(row - 3 > 0)
            {
                check1 = board[row - 1, col];
                check2 = board[row - 2, col];
                check3 = board[row - 3, col];
                if(playerColor == check3 && check2 == check1 && check2 != 0 && check1 != 0 && playerColor != check1)
                {
                    board[row - 1, col] = 0;
                    board[row - 2, col] = 0;
                    pointsGained += 2;
                }
            }
            //Check Down
            if (row + 3 < 21) 
            {
                check1 = board[row + 1, col];
                check2 = board[row + 2, col];
                check3 = board[row + 3, col];
                if (playerColor == check3 && check2 == check1 && check2 != 0 && check1 != 0 && playerColor != check1)
                {
                    board[row + 1, col] = 0;
                    board[row + 2, col] = 0;
                    pointsGained += 2;
                }
            }
            //Check Left
            if (col - 3 > 0) 
            {
                check1 = board[row, col - 1];
                check2 = board[row, col - 2];
                check3 = board[row, col - 3];
                if (playerColor == check3 && check2 == check1 && check2 != 0 && check1 != 0 && playerColor != check1)
                {
                    board[row, col - 1] = 0;
                    board[row, col - 2] = 0;
                    pointsGained += 2;
                }
            }
            //Check Right
            if(col + 3 < 21) 
            {
                check1 = board[row, col + 1];
                check2 = board[row, col + 2];
                check3 = board[row, col + 3];
                if (playerColor == check3 && check2 == check1 && check2 != 0 && check1 != 0 && playerColor != check1)
                {
                    board[row, col + 1] = 0;
                    board[row, col + 2] = 0;
                    pointsGained += 2;
                }
            }

            //Check Top Left
            if(row - 3 > 0 && col - 3 > 0) 
            {
                check1 = board[row - 1, col - 1];
                check2 = board[row - 2, col - 2];
                check3 = board[row - 3, col - 3];
                if (playerColor == check3 && check2 == check1 && check2 != 0 && check1 != 0 && playerColor != check1)
                {
                    board[row - 1, col - 1] = 0;
                    board[row - 2, col - 2] = 0;
                    pointsGained += 2;
                }
            }
            //Check Top Right
            if(row - 3 > 0 && col + 3 < 21) {
                check1 = board[row - 1, col + 1];
                check2 = board[row - 2, col + 2];
                check3 = board[row - 3, col + 3];
                if (playerColor == check3 && check2 == check1 && check2 != 0 && check1 != 0 && playerColor != check1)
                {
                    board[row - 1, col + 1] = 0;
                    board[row - 2, col + 2] = 0;
                    pointsGained += 2;
                }
            }
            //Check Bottom Left
            if(row + 3 < 21 && col - 3 > 0) {
                check1 = board[row + 1, col - 1];
                check2 = board[row + 2, col - 2];
                check3 = board[row + 3, col - 3];
                if (playerColor == check3 && check2 == check1 && check2 != 0 && check1 != 0 && playerColor != check1)
                {
                    board[row + 1, col - 1] = 0;
                    board[row + 2, col - 2] = 0;
                    pointsGained += 2;
                }
            }
            //Check Bottom Right
            if(row + 3 < 21 && col + 3 < 21) {
                check1 = board[row + 1, col + 1];
                check2 = board[row + 2, col + 2];
                check3 = board[row + 3, col + 3];
                if (playerColor == check3 && check2 == check1 && check2 != 0 && check1 != 0 && playerColor != check1)
                {
                    board[row + 1, col + 1] = 0;
                    board[row + 2, col + 2] = 0;
                    pointsGained += 2;
                }
            }

            return pointsGained;
        }

        public int CheckVictory(int[,] board, int row, int col)
        {
            //checks each direction for the longest line
            //return the longest line
            int longestCount = 0;
            int playerCount = board[row, col];
            //up
            for (int i = 0; i < 5; i++)
            {
                if (board[row - i, col] != playerCount) break;
                if (longestCount < i + 1) longestCount = i + 1;
            }
            //down
            for(int i = 0; i < 5; i++)
            {
                if (board[row + i, col] != playerCount) break;
                if (longestCount < i + 1) longestCount = i + 1;
            }
            //left
            for (int i = 0; i < 5; i++)
            {
                if (board[row, col - i] != playerCount) break;
                if (longestCount < i + 1) longestCount = i + 1;
            }
            //right
            for (int i = 0; i < 5; i++)
            {
                if (board[row, col + i] != playerCount) break;
                if (longestCount < i + 1) longestCount = i + 1;
            }
            //top left
            for (int i = 0; i < 5; i++)
            {
                if (board[row - i, col - i] != playerCount) break;
                if (longestCount < i + 1) longestCount = i + 1;
            }
            //top right
            for (int i = 0; i < 5; i++)
            {
                if (board[row - i, col + i] != playerCount) break;
                if (longestCount < i + 1) longestCount = i + 1;
            }
            //bottom left
            for (int i = 0; i < 5; i++)
            {
                if (board[row + i, col - i] != playerCount) break;
                if (longestCount < i + 1) longestCount = i + 1;
            }
            //bottom right
            for (int i = 0; i < 5; i++)
            {
                if (board[row + i, col + i] != playerCount) break;
                if (longestCount < i + 1) longestCount = i + 1;
            }


            return longestCount;
        }


        public void PlayerWins(Player p1, Player p2, Player winner)
        {
            Results results = new Results(p1.name, p2.name, p1.color.ToString(), p2.color.ToString(), winner.name);// Need to add a player who won
            results.Show();
            this.Close();
        }
        //Opens up results window

        public void UpdateBoard()
        {
            Player1Name.Content = p1.name;
            Player2Name.Content = p2.name;
            Player1Steals.Content = "Steals: " + p1.points;
            Player2Steals.Content = "Steals: " + p2.points;
            for (int row = 1; row < 20; row++)
            {
                for (int col = 1; col < 20; col++) 
                {
                    Button btn = Grid.Children.Cast<Button>().First(e => Grid.GetRow(e) == row && Grid.GetColumn(e) == col);

                    switch (board[row, col])
                    {
                        case 0:
                            //Switch Color to Gray
                            btn.Background = Brushes.Gray;
                            break;
                        case 1:
                            //Switch to P1 Color
                            btn.Background = Brushes.White;
                            break;
                        case 2:
                            //Switch to P2 Color
                            btn.Background = Brushes.Black;
                            break;
                    }
                }
            }
        }

    }
}
