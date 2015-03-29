namespace _02.BankAccounts
{
    public abstract class Account
    {
        private Customer accountOwner;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer accountOwner, decimal balance, decimal interestRate)
        {
            this.AccountOwner = accountOwner;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer AccountOwner
        {
            get
            {
                return this.accountOwner;
            }
            private set
            {
                if (value == null)
                {
                    throw new System.ArgumentNullException("Account must have an owner!");
                }

                this.accountOwner = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentOutOfRangeException("Interest rate should be possitive!");
                }

                this.interestRate = value;
            }
        }

        public void Deposit(decimal money)
        {
            if (money <= 0)
            {
                throw new System.ArgumentOutOfRangeException("Deposit should be possitive!");
            }

            this.Balance += money;
        }

        public abstract decimal CalculateInterestAmountForAPeriod(int months);
    }
}
