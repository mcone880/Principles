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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        // Mathew , Josh
        List<Image> matches = new List<Image>();
        string p1;
        string p2;
        Difficulty difficulty;
        int playerTurn = 1;


        public Game(Difficulty d, Name name)
        {
            InitializeComponent();
            p1 = name.playerOne.Text;
            p2 = name.playerTwo.Text;
            difficulty = d;
            StartGame(difficulty);
        }

        public void StartGame(Difficulty d)
        {
            Player1.Text = p1;
            Player2.Text = p2;
            
            switch(d.chosen)
            {
                case Difficulty.Difficulties.Easy:
                    CreateGame(new List<int>{1, 3, 5});
                    break;
                case Difficulty.Difficulties.Medium:
                    CreateGame(new List<int> { 1, 3, 5, 7 });
                    break;
                case Difficulty.Difficulties.Hard:
                    CreateGame(new List<int> { 3, 5, 7, 9, 11 });
                    break;
            }
        }

        public void CreateGame(List<int> numPerRow)
        {
            for(int i = 0; i < numPerRow.Count; i++)
            {
                for(int j = 0; j < numPerRow[i]; j++)
                {
                    CreateImage(numPerRow, i, j);
                }
            }
            MainGrid.Children.Remove(Match);
        }


        public void CreateImage(List<int>numPerRow, int i, int j)
        {
            Image img = new Image();
            img.Source = Match.Source;
            img.Visibility = Visibility.Visible;
            MainGrid.RegisterName("Match" + i + j, img);
            double width = MainGrid.ColumnDefinitions[1].ActualWidth;
            double spacePerImage = width / numPerRow[i];
            img.Margin = new Thickness(spacePerImage * (i + 1), 10, 0, 0);
            Grid.SetColumn(img, 1);
            Grid.SetRow(img, i);
            MainGrid.Children.Add(img);
            matches.Add(img);
        }

        private void RowDelete(object sender, RoutedEventArgs e)
        {
            int row = Grid.GetRow((Button)sender);
            foreach (var element in MainGrid.Children)
            {
                if (element is Button)
                {
                    Button btn = (Button)element;
                    if(btn != sender && btn != btnEndTurn)
                    {
                        btn.IsEnabled = false;
                    }
                }
            }
            btnEndTurn.IsEnabled = true;
            DeleteMatch(row);
        }

        public void Next(string p1, string p2)
        {
            string winner;
            if (playerTurn == 1) winner = p1;
            else winner = p2;
            Results results = new Results(p1, p2, winner, this);
            results.Show();
            this.Hide();
        }

        public void DeleteMatch(int row)
        {
            foreach (var element in MainGrid.Children)
            {
                if (element is Image)
                {
                    Image image = (Image)element;
                    if (Grid.GetRow(image) == row)
                    {
                        MainGrid.Children.Remove(image);
                        matches.Remove(image);
                        break;
                    }
                }
            }
            if (matches.Count == 0)
            {
                if (playerTurn == 1) playerTurn = 2;
                else playerTurn = 1;
                Next(p1, p2);
            }
        }

        private void EndTurn(object sender, RoutedEventArgs e)
        {
            if (playerTurn == 1) playerTurn = 2;
            else playerTurn = 1;

            foreach (var element in MainGrid.Children)
            {
                if (element is Button)
                {
                    Button btn = (Button)element;
                    btn.IsEnabled = true;
                }
            }
        }
    }
}
