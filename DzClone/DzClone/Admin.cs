namespace DzClone
{
    // Администратор является пользователем, но с бОльшими правами
    public class Admin : User, IMyCloneable<Admin>, ICloneable
    {
        public bool IsAdmin { get; set; }

        public Admin(int accountId, string accountName, decimal balance, string firstName, string lastName, bool isAdmin) : base(accountId, accountName, balance, firstName, lastName)
        {
            IsAdmin = isAdmin;
        }

        public new Admin Clone()
        {
            return new Admin(AccountId, AccountName, Balance, FirstName, LastName, IsAdmin);
        }

        object ICloneable.Clone()
        {
            return new Admin(AccountId, AccountName, Balance, FirstName, LastName, IsAdmin);
        }
    }
}
