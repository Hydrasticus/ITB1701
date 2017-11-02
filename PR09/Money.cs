namespace PR09 {
    public class Money {
        private int _amount;
        private string _currency;

        public Money(int amount, string currency) {
            _amount = amount;
            _currency = currency;
        }

        public void AddMoney(Money money) {
            _amount += money._amount;
        }
        
        public string Currency {
            get { return _currency; }
        }

        public int Amount {
            get { return _amount; }
        }
    }
}