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
    public partial class Difficulty : Window
    {
        public enum Difficulties
        {
            Easy,
            Medium,
            Hard
        }

        public Name _name;

        public Difficulty(Name name)
        {
            InitializeComponent();
            _name = name;
        }

        public Difficulties chosen;

        private void easyBtn_Click(object sender, RoutedEventArgs e)
        {
            chosen = Difficulties.Easy;
            next();
        }

        private void medBtn_Click(object sender, RoutedEventArgs e)
        {
            chosen = Difficulties.Medium;
            next();
        }

        private void hardBtn_Click(object sender, RoutedEventArgs e)
        {
            chosen = Difficulties.Hard;
            next();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Name name = new Name();
            name.Show();
            this.Close();
        }

        private void next()
        {
            Game game = new Game(this);
            game.Show();
            this.Close();
        }
    }
}
