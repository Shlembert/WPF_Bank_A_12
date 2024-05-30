using System.Windows;

namespace BankApp
{
    public partial class ClientDetailsWindow : Window
    {
        private Client client;

        public ClientDetailsWindow(Client client)
        {
            InitializeComponent();
            this.client = client;
            NameTextBlock.Text = client.Name;
            AccountsDataGrid.ItemsSource = client.Accounts;
        }

        private void NewAccountButton_Click(object sender, RoutedEventArgs e)
        {
            NewAccountWindow newAccountWindow = new NewAccountWindow(client);
            newAccountWindow.ShowDialog();
            AccountsDataGrid.Items.Refresh();
        }

        private void DeleteAccountButton_Click(object sender, RoutedEventArgs e)
        {
            if (AccountsDataGrid.SelectedItem is Account selectedAccount)
            {
                client.Accounts.Remove(selectedAccount);
                ClientDataHandler.SaveClients(MainWindow.Clients);
                AccountsDataGrid.Items.Refresh();

                MessageBox.Show($"Счет {selectedAccount.AccountNumber} удален.");
            }
        }

        private void TransferButton_Click(object sender, RoutedEventArgs e)
        {
            if (client.Accounts.Count == 1)
            {
                MessageBox.Show("У вас только один счет. Чтобы сделать перевод, создайте новый счет.");
            }
            else
            {
                TransferWindow transferWindow = new TransferWindow(client);
                transferWindow.ShowDialog();
                AccountsDataGrid.Items.Refresh();
            }
        }



        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            if (AccountsDataGrid.SelectedItem is Account selectedAccount)
            {
                DepositWithdrawWindow depositWindow = new DepositWithdrawWindow(selectedAccount, true);
                depositWindow.ShowDialog();
                AccountsDataGrid.Items.Refresh();
            }
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            if (AccountsDataGrid.SelectedItem is Account selectedAccount)
            {
                DepositWithdrawWindow withdrawWindow = new DepositWithdrawWindow(selectedAccount, false);
                withdrawWindow.ShowDialog();
                AccountsDataGrid.Items.Refresh();
            }
        }
    }
}
