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
        public string color;
    } 

    public partial class Game : Window
    {
        Player p1 = new Player();
        Player p2 = new Player();
        Player currentPlayer;

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

        }
        

        //public void CheckSteals(2D array board, int row, int col)
        //if steal
        //change the buttons
        //increment the steals of current Player

        //public int CheckVictory(2D array board, int row, int col)
        //checks each direction for the longest line
        //return the longest line

        
        public void PlayerWins(string playerName, string color)
        {
            Results results = new Results();// Need to add a player who won
            results.Show();
            this.Close();
        }
        //Opens up results window

        //button being pressed
        //check if valid button pressed
        //if valid button
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


    }
}
