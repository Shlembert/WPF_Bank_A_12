using System;
using System.Windows;

namespace BankApp
{
    public partial class NewClientWindow : Window
    {
        // Событие для уведомления о добавлении клиента
        public event EventHandler<Client> ClientAdded;

        // Конструктор окна
        public NewClientWindow()
        {
            InitializeComponent();
        }

        // Обработчик клика на кнопку добавления клиента
        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            string clientName = ClientNameTextBox.Text;
            if (!string.IsNullOrWhiteSpace(clientName))
            {
                Client newClient = new Client(clientName);
                ClientAdded?.Invoke(this, newClient);
                Close();
            }
            else
            {
                MessageBox.Show("Имя клиента не может быть пустым.");
            }
        }
    }
}
