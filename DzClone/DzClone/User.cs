namespace DzClone
{
    // Класс обычного пользователя
    public class User : Account, IMyCloneable<User>, ICloneable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User(int accountId, string accountName, decimal balance, string firstName, string lastName) : base(accountId, accountName, balance)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public User Clone()
        {
            return new User(AccountId, AccountName, Balance, FirstName, LastName);
        }

        object ICloneable.Clone()
        {
            return new User(AccountId, AccountName, Balance, FirstName, LastName);
        }
    }
}
