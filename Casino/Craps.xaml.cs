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

namespace Casino
{
    /// <summary>
    /// Interaction logic for Craps.xaml
    /// </summary>
    public partial class Craps : Window
    {
        int Money;
        Image[] Images = new Image[12];

        public Craps(int money)
        {
            InitializeComponent();
            Money = money;
            CrapsWindow.Width = 815;
            CrapsWindow.Height = 725;
            CrapsWindow.ResizeMode = ResizeMode.NoResize;
            lblMoney.Content = "Money: " + money.ToString();

            int j = 0;
            for (int i = 1; i < 7; i++)
            {
                Image img = (Image)FindName("Col1Dice" + i);
                Images[j] = img;
                j++;
            }
            for (int i = 1; i < 7; i++)
            {
                Image img = (Image)FindName("Col2Dice" + i);
                Images[j] = img;
                j++;
            }
        }

        public int[] Roll()
        {
            Random r = new Random();
            int dice1 = r.Next(1, 7);
            int dice2 = r.Next(1, 7);
            int total = dice1 + dice2;
            int[] nums = new int[3];
            nums[0] = dice1;
            nums[1] = dice2;
            nums[2] = total;

            return nums;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            GameSelection game = new GameSelection(Money);
            game.Show();
            Close();
        }

        private void RollButton_Click(object sender, RoutedEventArgs e)
        {
            var results = Roll();
            SetImages(results[0], results[1]);
        }

        private void SetImages(int dice1, int dice2)
        {
            foreach (Image image in Images)
            {
                image.Visibility = Visibility.Hidden;
            }

            Image image1 = (Image)FindName("Col1Dice" + dice1);
            Image image2 = (Image)FindName("Col2Dice" + dice2);
            image1.Visibility = Visibility.Visible;
            image2.Visibility = Visibility.Visible;
        }
    }
}
