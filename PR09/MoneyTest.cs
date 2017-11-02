using NUnit.Framework;

namespace PR09 {
    [TestFixture]
    public class MoneyTest {
        private Money f12EUR;
        private Money f14EUR;
        private Money f7USD;
        private Money f21USD;

        private Wallet fMB1;
        private Wallet fMB2;

        [SetUp]
        public void TestSetup() {
            f12EUR = new Money(12, "EUR");
            f14EUR = new Money(14, "EUR");
            f7USD = new Money(7, "USD");
            f21USD = new Money(21, "USD");
            
            fMB1 = new Wallet(f12EUR);
            fMB2 = new Wallet(f14EUR);
        }

        [Test]
        public void WalletContainsValue() {
            Money a = fMB1.FindMoney("EUR");
            
            Assert.IsTrue(a == f12EUR);
            Assert.IsTrue(a.Currency == "EUR");
        }

        [Test]
        public void MoneyWasAddedToWallet() {
            // 12 EUR + 14 EUR = 26 EUR
            fMB1.AppendMoney(f14EUR);

            Money moneyInTheWallet = fMB1.FindMoney("EUR");
            
            Assert.IsTrue(26 == moneyInTheWallet.Amount);
        }
    }
}