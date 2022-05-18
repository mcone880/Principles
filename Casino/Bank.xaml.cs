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
    /// Interaction logic for Bank.xaml
    /// </summary>
    public partial class Bank : Window
    {
        int chipAmount;
        int bankAmount;

        public Bank(int chips, int bank)
        {
            chipAmount = chips;
            bankAmount = bank;
            InitializeComponent();
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            ChipAmountLabel.Content = "$" + chipAmount;
            BankAmountLabel.Content = "$" + bankAmount;
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            GameSelection newWindow = new GameSelection(chipAmount, bankAmount);
            newWindow.Show();
            this.Close();
        }

        private void WithdrawClick(object sender, RoutedEventArgs e)
        {
            bankAmount -= GetNumberFromTextBox();
            chipAmount += GetNumberFromTextBox();
            UpdateLabels();
        }

        private void DepositClick(object sender, RoutedEventArgs e)
        {
            if(chipAmount >= GetNumberFromTextBox())
            {
                bankAmount += GetNumberFromTextBox();
                chipAmount -= GetNumberFromTextBox();
                UpdateLabels();
            }
        }

        private int GetNumberFromTextBox()
        {
            return int.Parse(AmountBox.Text);
        }
    }
}
