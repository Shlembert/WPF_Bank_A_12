using System.Collections.Generic;
using System.Windows;

namespace BankApp
{
    public partial class MainWindow : Window
    {
        private List<Client> clients;

        public MainWindow()
        {
            InitializeComponent();
            clients = ClientDataHandler.LoadClients();
            foreach (var client in clients)
            {
                ClientsListBox.Items.Add(client.Name);
            }
        }

        private void NewClient_Click(object sender, RoutedEventArgs e)
        {
            NewClientWindow newClientWindow = new NewClientWindow();
            newClientWindow.ClientAdded += NewClientWindow_ClientAdded;
            newClientWindow.ShowDialog();
        }

        private void NewClientWindow_ClientAdded(object sender, Client newClient)
        {
            clients.Add(newClient);
            ClientsListBox.Items.Add(newClient.Name);
            ClientDataHandler.SaveClients(clients);
        }

        private void ClientsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ClientsListBox.SelectedItem != null)
            {
                string selectedClientName = ClientsListBox.SelectedItem.ToString();
                Client selectedClient = clients.Find(c => c.Name == selectedClientName);
                OpenClientDetailsWindow(selectedClient);
            }
        }

        private void OpenClientDetailsWindow(Client client)
        {
            ClientDetailsWindow clientDetailsWindow = new ClientDetailsWindow(client);
            clientDetailsWindow.Show();
        }
    }
}
