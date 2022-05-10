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
        public Craps(int money)
        {
            InitializeComponent();
            lblMoney.Content = "Money: " + money.ToString();
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


    }
}
