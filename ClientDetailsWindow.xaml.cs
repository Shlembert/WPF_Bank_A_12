using System.Windows;
using System.Windows.Controls;

namespace BankApp
{
    public partial class ClientDetailsWindow : Window
    {
        private Client _client;

        public ClientDetailsWindow(Client client)
        {
            InitializeComponent();
            _client = client;
            LoadClientDetails();
        }

        private void LoadClientDetails()
        {
            // Загрузка данных клиента в элементы интерфейса
            NameTextBlock.Text = _client.Name;
            AccountsDataGrid.ItemsSource = _client.Accounts;
        }

        private void NewAccountButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика создания нового счета
        }

        private void DeleteAccountButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика удаления счета
        }

        private void TransferButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика перевода средств
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика пополнения счета
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика снятия средств
        }
    }
}
