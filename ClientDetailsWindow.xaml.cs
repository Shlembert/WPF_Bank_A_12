using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BankApp
{
    public partial class ClientDetailsWindow : Window
    {
        private Bank bank;
        private Client client;

        public ClientDetailsWindow(Bank bank, Client client)
        {
            InitializeComponent();
            this.bank = bank;
            this.client = client;
            ClientNameTextBlock.Text = client.Name;
            UpdateAccountList();
        }

        private void OpenAccount_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(AccountNumberTextBox.Text, out int accountNumber) &&
                decimal.TryParse(InitialBalanceTextBox.Text, out decimal initialBalance) &&
                AccountTypeComboBox.SelectedItem is ComboBoxItem selectedType)
            {
                Account account;
                if (selectedType.Content.ToString() == "Недепозитный")
                {
                    account = new NonDepositAccount(accountNumber, initialBalance);
                }
                else
                {
                    account = new DepositAccount(accountNumber, initialBalance);
                }

                bank.OpenAccount(client, account);
                UpdateAccountList();

                // Очистка полей ввода
                AccountNumberTextBox.Clear();
                InitialBalanceTextBox.Clear();
                AccountTypeComboBox.SelectedIndex = -1;
                MessageBox.Show("Счет успешно открыт.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите правильные данные.");
            }
        }

        private void CloseAccount_Click(object sender, RoutedEventArgs e)
        {
            if (AccountsListBox.SelectedItem is string selectedItem)
            {
                int startIndex = selectedItem.IndexOf("№") + 1;
                int endIndex = selectedItem.IndexOf(":");
                int accountNumber = int.Parse(selectedItem.Substring(startIndex, endIndex - startIndex));
                Account account = client.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

                if (account != null)
                {
                    bank.CloseAccount(client, account);
                    UpdateAccountList();
                    MessageBox.Show("Счет успешно закрыт.");
                }
                else
                {
                    MessageBox.Show("Выберите счет для закрытия.");
                }
            }
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(FromAccountTextBox.Text, out int fromAccountNumber) &&
                int.TryParse(ToAccountTextBox.Text, out int toAccountNumber) &&
                decimal.TryParse(TransferAmountTextBox.Text, out decimal amount))
            {
                Account fromAccount = client.Accounts.FirstOrDefault(a => a.AccountNumber == fromAccountNumber);
                Account toAccount = client.Accounts.FirstOrDefault(a => a.AccountNumber == toAccountNumber);

                if (fromAccount != null && toAccount != null)
                {
                    fromAccount.Transfer(toAccount, amount);
                    UpdateAccountList();
                    MessageBox.Show($"Перевод выполнен успешно.\nСчет отправителя: {fromAccountNumber}\nСчет получателя: {toAccountNumber}\nСумма перевода: {amount:C}");
                }
                else
                {
                    MessageBox.Show("Один или оба счета не найдены.");
                }
            }
            else
            {
                MessageBox.Show("Номера счетов и сумма перевода должны быть валидными числами.");
            }
        }

        private void UpdateAccountList()
        {
            AccountsListBox.Items.Clear();
            foreach (var account in client.Accounts)
            {
                string accountType = account is DepositAccount ? "Депозитный" : "Недепозитный";
                AccountsListBox.Items.Add($"Счет №{account.AccountNumber}: {account.Balance:C} ({accountType})");
            }
        }

        private void AccountsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AccountsListBox.SelectedItem is string selectedItem)
            {
                int startIndex = selectedItem.IndexOf("№") + 1;
                int endIndex = selectedItem.IndexOf(":");
                string accountNumber = selectedItem.Substring(startIndex, endIndex - startIndex);
                SelectedAccountTextBox.Text = accountNumber;
            }
        }
    }
}
