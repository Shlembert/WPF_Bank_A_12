using System;
using System.Windows;

namespace BankApp
{
    public partial class NewAccountWindow : Window
    {
        private Client client;

        public NewAccountWindow(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string accountNumber = random.Next(100000000, 999999999).ToString();
            AccountNumberTextBox.Text = accountNumber;
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(AccountNumberTextBox.Text))
            {
                MessageBox.Show("Сначала сгенерируйте номер счета.");
                return;
            }

            int accountNumber = int.Parse(AccountNumberTextBox.Text.Replace(" ", ""));
            Account newAccount;

            if (DepositRadioButton.IsChecked == true)
            {
                newAccount = new DepositAccount(accountNumber, 0);
            }
            else if (NonDepositRadioButton.IsChecked == true)
            {
                newAccount = new NonDepositAccount(accountNumber, 0);
            }
            else
            {
                MessageBox.Show("Выберите тип счета.");
                return;
            }

            client.Accounts.Add(newAccount);
            ClientDataHandler.SaveClients(MainWindow.Clients);
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
