using System;
using System.Linq;
using System.Windows;

namespace BankApp
{
    public partial class TransferWindow : Window
    {
        private Client client;
        private Account sourceAccount;

        public TransferWindow(Client client, Account sourceAccount)
        {
            InitializeComponent();
            this.client = client;
            this.sourceAccount = sourceAccount;

            // Установка текста TextBlock для выбранного счета
            SourceAccountTextBlock.Text = $"Счет списания: {sourceAccount.AccountNumber}";
            SourceAccountTextBlock.Visibility = Visibility.Visible;

            // Заполнение комбо-бокса счетами клиента
            FillAccountsComboBox();
        }

        private void FillAccountsComboBox()
        {
            // Очистка комбо-бокса перед заполнением
            AccountsComboBox.Items.Clear();

            // Добавление номеров счетов клиента в комбо-бокс, исключая выбранный для списания
            foreach (var account in client.Accounts.Where(a => a.AccountNumber != sourceAccount.AccountNumber))
            {
                AccountsComboBox.Items.Add(account.AccountNumber);
            }
        }

        private void TransferButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelfTransferRadioButton.IsChecked == true)
            {
                // Перевод на свой счет
                if (AccountsComboBox.SelectedItem != null)
                {
                    int selectedAccountNumber = (int)AccountsComboBox.SelectedItem;
                    Account selectedAccount = client.Accounts.FirstOrDefault(account => account.AccountNumber == selectedAccountNumber);
                    if (selectedAccount != null)
                    {
                        if (!string.IsNullOrWhiteSpace(AmountTextBox.Text) && decimal.TryParse(AmountTextBox.Text, out decimal amount) && amount > 0)
                        {
                            if (sourceAccount.Balance >= amount)
                            {
                                sourceAccount.Withdraw(amount);
                                selectedAccount.Deposit(amount);
                                MessageBox.Show($"Средства успешно переведены на счет {selectedAccountNumber}");
                                ClientDataHandler.SaveClients(MainWindow.Clients);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Недостаточно средств на счете для перевода.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите корректную положительную сумму перевода.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выберите счет для перевода.");
                    }
                }
            }
            else if (OtherClientTransferRadioButton.IsChecked == true)
            {
                // Перевод на счет другого клиента
                // Здесь нужно добавить логику для выбора клиента и счета другого клиента
                // После выбора клиента и счета выполнить перевод средств
            }
            else
            {
                MessageBox.Show("Выберите тип перевода.");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SelfTransferRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // При выборе опции "На свой счет" скрываем комбо-бокс выбора клиента
            ClientsComboBox.Visibility = Visibility.Collapsed;
            AccountsComboBox.Visibility = Visibility.Visible;

            // Заполняем комбо-бокс счетами клиента
            FillAccountsComboBox();
        }

        private void OtherClientTransferRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // При выборе опции "На счет другого клиента" скрываем комбо-бокс выбора счета и отображаем комбо-бокс выбора клиента
            ClientsComboBox.Visibility = Visibility.Visible;
            AccountsComboBox.Visibility = Visibility.Collapsed;

            // Здесь можно заполнить комбо-бокс списком других клиентов
        }
    }
}
