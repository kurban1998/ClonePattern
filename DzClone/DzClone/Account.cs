namespace DzClone
{
    // базовый класс от коротого наследуется User
    public class Account
    {
        public int AccountId { get; set; }

        public string AccountName { get; set; }

        public decimal Balance { get; set; }

        public Account(int accountId, string accountName, decimal balance)
        {
            AccountId = accountId;
            AccountName = accountName;
            Balance = balance;
        }
    }
}
