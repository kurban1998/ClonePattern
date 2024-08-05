using DzClone;

namespace DzCloneTests
{
    [TestClass]
    public class CloneTests
    {
        [TestMethod]
        public void CloneUser()
        {
            // ������� ������ ��� ������������
            var original = new User(1, "Ivan", 5000, "Ivan", "Ivanov");

            // ��������� ������
            var clone = original.Clone();

            // ���������, ��� ���� ����� �� �� ������, �� �������� ��������� ��������
            Assert.AreEqual(original.AccountId, clone.AccountId);
            Assert.AreEqual(original.AccountName, clone.AccountName);
            Assert.AreEqual(original.Balance, clone.Balance);
            Assert.AreEqual(original.FirstName, clone.FirstName);
            Assert.AreEqual(original.LastName, clone.LastName);
            Assert.AreNotEqual(original, clone);
        }

        [TestMethod]
        public void CloneAdmin()
        {
            // ������� ������ ��� ������������
            var original = new Admin(2, "Ivan", 5000, "Ivan", "Ivanov", true);

            // ��������� ������
            var clone = original.Clone();

            // ���������, ��� ���� ����� �� �� ������, �� �������� ��������� ��������
            Assert.AreEqual(original.AccountId, clone.AccountId);
            Assert.AreEqual(original.AccountName, clone.AccountName);
            Assert.AreEqual(original.Balance, clone.Balance);
            Assert.AreEqual(original.FirstName, clone.FirstName);
            Assert.AreEqual(original.LastName, clone.LastName);
            Assert.AreEqual(original.IsAdmin, clone.IsAdmin);
            Assert.AreNotEqual(original, clone);
        }



    }
}