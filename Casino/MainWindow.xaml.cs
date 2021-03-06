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

namespace Casino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainMenu(object sender, RoutedEventArgs e)
        {
            GameSelection gameSelection = new GameSelection(0, 1000); //Change before final update
            gameSelection.Show();
            this.Close();
        }

        private void CreditsButton_Click(object sender, RoutedEventArgs e)
        {
            Credits newWindow = new Credits();
            newWindow.Show();
        }
    }
}
