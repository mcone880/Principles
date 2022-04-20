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
    public partial class Game : Window
    {
        string p1Name;
        string p2Name;
        string p1Color;
        string p2Color;

        public Game(string p1Name, string p2Name, string p1Color, string p2Color)
        {
            this.p1Name = p1Name;
            this.p2Name = p2Name;
            this.p1Color = p1Color;
            this.p2Color = p2Color;
            InitializeComponent();
            //Set Player 1 has first player
        }

        //public void CheckSteals(2D array board, int row, int col)
            //if steal
                //change the buttons
                //increment the steals of current Player

        //public int CheckVictory(2D array board, int row, int col)
            //checks each direction for the longest line
            //return the longest line

        //public void PlayerWins(string playerName, string color)
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
