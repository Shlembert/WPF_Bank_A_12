using System.Windows;

namespace BankApp
{
    public partial class ClientDetailsWindow : Window
    {
        public ClientDetailsWindow(string clientName)
        {
            InitializeComponent();
            ClientNameTextBlock.Text = clientName;
        }

        private void OpenAccount_Click(object sender, RoutedEventArgs e)
        {
            // Логика открытия счета
        }

        private void CloseAccount_Click(object sender, RoutedEventArgs e)
        {
            // Логика закрытия счета
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            // Логика перевода средств
        }

        private void AccountsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Логика выбора счета
        }
    }
}
