using System.Windows;

namespace BankApp
{
    public partial class DepositWithdrawWindow : Window
    {
        private Account account;
        private bool isDeposit;

        public DepositWithdrawWindow(Account account, bool isDeposit)
        {
            InitializeComponent();
            this.account = account;
            this.isDeposit = isDeposit;
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(AmountTextBox.Text))
            {
                MessageBox.Show("Введите сумму операции.");
                return;
            }

            decimal amount;
            if (!decimal.TryParse(AmountTextBox.Text, out amount))
            {
                MessageBox.Show("Введите корректную сумму.");
                return;
            }

            if (isDeposit)
            {
                account.Deposit(amount);
            }
            else
            {
                account.Withdraw(amount);
            }

            ClientDataHandler.SaveClients(MainWindow.Clients);
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
