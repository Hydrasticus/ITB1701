using System.Collections.Generic;

namespace PR09 {
    public class Wallet {
        List<Money> _moneyInWallet = new List<Money>();
        
        public Wallet(Money money) {
            _moneyInWallet.Add(money);
        }

        public void AppendMoney(Money money) {
            Money currentMoney = FindMoney(money.Currency);

            if (currentMoney == null) {
                _moneyInWallet.Add(money);
                return;
            } else {
                currentMoney.AddMoney(money);
            }
        }
        
        public Money FindMoney(string currency) {
            foreach (var money in _moneyInWallet) {
                if (money.Currency.Equals(currency)) {
                    return money;
                }
            }
            return null;
        }
    }
}