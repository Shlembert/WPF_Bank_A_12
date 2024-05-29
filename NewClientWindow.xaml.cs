using System.Windows;

namespace BankApp
{
    public partial class NewClientWindow : Window
    {
        public event EventHandler<string> ClientAdded;
        private List<string> existingClients;

        public NewClientWindow(List<string> clients)
        {
            InitializeComponent();
            existingClients = clients;
        }

        private void SaveClient_Click(object sender, RoutedEventArgs e)
        {
            // Логика сохранения нового клиента
            string newClientName = NewClientNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(newClientName))
            {
                MessageBox.Show("Пожалуйста, введите имя клиента.");
                return;
            }

            if (existingClients.Contains(newClientName))
            {
                MessageBox.Show("Клиент с таким именем уже существует. Пожалуйста, выберите другое имя.");
                return;
            }

            ClientAdded?.Invoke(this, newClientName);
            this.Close();
        }
    }
}
