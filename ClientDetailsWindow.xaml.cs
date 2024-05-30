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
            // Implement account deletion logic
        }

        private void TransferButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement transfer logic
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement deposit logic
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement withdrawal logic
        }
    }
}
