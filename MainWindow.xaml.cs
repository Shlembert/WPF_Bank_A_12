using System.Collections.Generic;
using System.Windows;

namespace BankApp
{
    public partial class MainWindow : Window
    {
        private List<string> clients;

        public MainWindow()
        {
            InitializeComponent();
            clients = new List<string>();
        }

        private void NewClient_Click(object sender, RoutedEventArgs e)
        {
            // Открываем новое окно для создания клиента
            NewClientWindow newClientWindow = new NewClientWindow(clients);
            newClientWindow.ClientAdded += NewClientWindow_ClientAdded;
            newClientWindow.ShowDialog();
        }

        private void NewClientWindow_ClientAdded(object sender, string newClientName)
        {
            // Добавляем нового клиента в список
            clients.Add(newClientName);
            ClientsListBox.Items.Add(newClientName);
        }

        private void ClientsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ClientsListBox.SelectedItem != null)
            {
                string selectedClient = ClientsListBox.SelectedItem.ToString();
                OpenClientDetailsWindow(selectedClient);
            }
        }

        private void OpenClientDetailsWindow(string clientName)
        {
            ClientDetailsWindow clientDetailsWindow = new ClientDetailsWindow(clientName);
            clientDetailsWindow.Show();
        }
    }
}
