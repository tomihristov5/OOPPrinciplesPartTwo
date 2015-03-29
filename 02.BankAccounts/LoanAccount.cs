namespace _02.BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer accountOwner, decimal balance, decimal interestRate)
            : base(accountOwner, balance, interestRate)
        {
            
        }

        public override decimal CalculateInterestAmountForAPeriod(int months)
        {
            if (this.AccountOwner is Individuals)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * (this.InterestRate / 100)) * (months - 3);
                }
            }
            else
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * (this.InterestRate / 100)) * (months - 2);
                }
            }
        }
    }
}
