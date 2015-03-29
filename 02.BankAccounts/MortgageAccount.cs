namespace _02.BankAccounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer accountOwner, decimal balance, decimal interestRate)
            : base(accountOwner, balance, interestRate)
        {
            
        }

        public override decimal CalculateInterestAmountForAPeriod(int months)
        {
            if (this.AccountOwner is Individuals)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    return (months - 6) * ((this.InterestRate / 100 * this.Balance));
                }
            }
            else
            {
                if (months <= 12)
                {
                    return months * (this.InterestRate / 200 * this.Balance);
                }
                else
                {
                    return (months - 12) * (this.InterestRate / 100 * this.Balance) +
                            12 * (this.InterestRate / 200 * this.Balance); 
                }
            }
        }
    }
}
