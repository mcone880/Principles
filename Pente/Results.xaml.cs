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
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        string p1Name;
        string p2Name;
        string p1Color;
        string p2Color;

        public Results(string p1, string p2, string p1color, string p2color, string winner)
        {
            InitializeComponent();
            p1Name = p1;
            p2Name = p2;
            p1Color = p1color;
            p2Color = p2color;
            ResultsWindow.Width = 815;
            ResultsWindow.Height = 475;
            PlayerWinLabel.Content = winner + " Wins";
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void StartOverButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void RematchButton_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game(p1Name, p2Name, p1Color, p2Color);
            game.Show();
            Close();
        }
    }
}
