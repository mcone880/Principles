﻿using System;
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
        public string color;
        public int points;
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
            p1.color = p1Color;
            p2.color = p2Color;
            InitializeComponent();
            //Set Player 1 has first player
            currentPlayer = p1;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            //btn.Background = currentPlayer.color;
            currentPlayer.points += CheckSteals(board, 1, 1); //Needs actual values
            
            
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
                if(playerColor != check1 && playerColor != check2 && playerColor == check3)
                {
                    board[row - 1, col] = 0;
                    board[row - 2, col] = 0;
                }
                pointsGained += 2;
            }
            //Check Down
            if (row + 3 < 21) 
            {
                check1 = board[row + 1, col];
                check2 = board[row + 2, col];
                check3 = board[row + 3, col];
                if (playerColor != check1 && playerColor != check2 && playerColor == check3)
                {
                    board[row + 1, col] = 0;
                    board[row + 2, col] = 0;
                }
                pointsGained += 2;
            }
            //Check Left
            if (col - 3 > 0) 
            {
                check1 = board[row, col - 1];
                check2 = board[row, col - 2];
                check3 = board[row, col - 3];
                if (playerColor != check1 && playerColor != check2 && playerColor == check3)
                {
                    board[row, col - 1] = 0;
                    board[row, col - 2] = 0;
                }
                pointsGained += 2;
            }
            //Check Right
            if(col + 3 < 21) 
            {
                check1 = board[row, col + 1];
                check2 = board[row, col + 2];
                check3 = board[row, col + 3];
                if (playerColor != check1 && playerColor != check2 && playerColor == check3)
                {
                    board[row, col + 1] = 0;
                    board[row, col + 2] = 0;
                }
                pointsGained += 2;
            }

            //Check Top Left
            if(row - 3 > 0 && col - 3 > 0) 
            {
                check1 = board[row - 1, col - 1];
                check2 = board[row - 2, col - 2];
                check3 = board[row - 3, col - 3];
                if (playerColor != check1 && playerColor != check2 && playerColor == check3)
                {
                    board[row - 1, col - 1] = 0;
                    board[row - 2, col - 2] = 0;
                }
                pointsGained += 2;
            }
            //Check Top Right
            if(row - 3 > 0 && col + 3 < 21) {
                check1 = board[row - 1, col + 1];
                check2 = board[row - 2, col + 2];
                check3 = board[row - 3, col + 3];
                if (playerColor != check1 && playerColor != check2 && playerColor == check3)
                {
                    board[row - 1, col + 1] = 0;
                    board[row - 2, col + 2] = 0;
                }
                pointsGained += 2;
            }
            //Check Bottom Left
            if(row + 3 < 21 && col - 3 > 0) {
                check1 = board[row + 1, col - 1];
                check2 = board[row + 2, col - 2];
                check3 = board[row + 3, col - 3];
                if (playerColor != check1 && playerColor != check2 && playerColor == check3)
                {
                    board[row + 1, col - 1] = 0;
                    board[row + 2, col - 2] = 0;
                }
                pointsGained += 2;
            }
            //Check Bottom Right
            if(row + 3 < 21 && col + 3 < 21) {
                check1 = board[row + 1, col + 1];
                check2 = board[row + 2, col + 2];
                check3 = board[row + 3, col + 3];
                if (playerColor != check1 && playerColor != check2 && playerColor == check3)
                {
                    board[row + 1, col + 1] = 0;
                    board[row + 2, col + 2] = 0;
                }
                pointsGained += 2;
            }

            return pointsGained;
        }

        public int CheckVictory(int[,] board, int row, int col)
        {
            
            for (int i = 0; i < row; i++)
            {

            }
        }
        //checks each direction for the longest line
        //return the longest line


        public void PlayerWins(string playerName, string color)
        {
            Results results = new Results();// Need to add a player who won
            results.Show();
            this.Close();
        }
        //Opens up results window

       


    }
}
