using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace BankApp
{
    public partial class TransferWindow : Window
    {
        private Client currentClient;

        public TransferWindow(Client currentClient)
        {
            InitializeComponent();
            this.currentClient = currentClient;

            // Заполняем комбобокс с клиентами
            ClientsComboBox.ItemsSource = MainWindow.Clients;
        }

        private void SelfTransferRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Если выбрано "На свой счет", показываем список счетов текущего клиента
            AccountsComboBox.ItemsSource = currentClient.Accounts;
            ClientsComboBox.Visibility = Visibility.Collapsed;
            AccountsComboBox.Visibility = Visibility.Visible;
        }

        private void OtherClientTransferRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Если выбрано "На счет другого клиента", показываем список всех клиентов
            ClientsComboBox.Visibility = Visibility.Visible;
            AccountsComboBox.Visibility = Visibility.Collapsed;
        }

        private void ClientsComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // При выборе клиента показываем список его счетов
            if (ClientsComboBox.SelectedItem is Client selectedClient)
            {
                AccountsComboBox.ItemsSource = selectedClient.Accounts;
            }
        }

        private void TransferButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelfTransferRadioButton.IsChecked == true)
            {
                // Перевод на собственный счет
                if (AccountsComboBox.SelectedItem is Account selectedAccount)
                {
                    if (string.IsNullOrEmpty(AmountTextBox.Text))
                    {
                        MessageBox.Show("Введите сумму операции.");
                        return;
                    }

                    decimal amount;
                    if (!decimal.TryParse(AmountTextBox.Text, out amount))
                    {
                        MessageBox.Show("Введите корректную сумму.");
                        return;
                    }

                    selectedAccount.Deposit(amount);
                    ClientDataHandler.SaveClients(MainWindow.Clients);
                    MessageBox.Show($"Сумма {amount} переведена на счет {selectedAccount.AccountNumber}.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Выберите счет для перевода.");
                }
            }
            else if (OtherClientTransferRadioButton.IsChecked == true)
            {
                // Перевод на счет другого клиента
                if (ClientsComboBox.SelectedItem is Client selectedClient && selectedClient.Accounts.Any())
                {
                    Account targetAccount = selectedClient.Accounts.First();

                    if (string.IsNullOrEmpty(AmountTextBox.Text))
                    {
                        MessageBox.Show("Введите сумму операции.");
                        return;
                    }

                    decimal amount;
                    if (!decimal.TryParse(AmountTextBox.Text, out amount))
                    {
                        MessageBox.Show("Введите корректную сумму.");
                        return;
                    }

                    targetAccount.Deposit(amount);
                    ClientDataHandler.SaveClients(MainWindow.Clients);
                    MessageBox.Show($"Сумма {amount} переведена на счет клиента {selectedClient.Name}.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Выберите клиента с существующим счетом.");
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
