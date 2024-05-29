using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BankApp
{
    public partial class MainWindow : Window
    {
        private Bank bank = new Bank();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            var clientName = ClientNameTextBox.Text;
            if (!string.IsNullOrWhiteSpace(clientName))
            {
                var client = new Client(clientName);
                bank.AddClient(client);
                UpdateClientList();
                ClientNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Имя клиента не может быть пустым.");
            }
        }

        private void ViewClientDetails_Click(object sender, RoutedEventArgs e)
        {
            if (ClientsListBox.SelectedItem is Client selectedClient)
            {
                var clientDetailsWindow = new ClientDetailsWindow(bank, selectedClient);
                clientDetailsWindow.Show();
            }
            else
            {
                MessageBox.Show("Выберите клиента из списка.");
            }
        }

        private void UpdateClientList()
        {
            ClientsListBox.Items.Clear();
            foreach (var client in bank.Clients)
            {
                ClientsListBox.Items.Add(client);
            }
        }
    }
}
