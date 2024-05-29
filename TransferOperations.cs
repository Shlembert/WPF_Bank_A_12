public class TransferOperations : ITransferOperations<Account>
{
    public void Transfer(Account fromAccount, Account toAccount, decimal amount)
    {
        fromAccount.Withdraw(amount);
        toAccount.Deposit(amount);
    }
}
