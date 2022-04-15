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
    /// Interaction logic for Name.xaml
    /// </summary>
    public partial class Name : Window
    {
        public string firstPlayer ;
        public string secondPlayer ;
        //David
        public Name()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (playerOne.Text == "")
            {
                playerOne.Text = "Player 1";
            }
            if (playerTwo.Text == "")
            {
                playerTwo.Text = "Player 2";
            }
            firstPlayer = playerOne.Text;
            secondPlayer = playerTwo.Text;
            Difficulty d = new Difficulty(this);
            d.Show();
            this.Close();
            
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wd = new MainWindow();
            wd.Show();
            this.Close();
        }
    }
}
