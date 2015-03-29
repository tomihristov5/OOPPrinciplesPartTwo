namespace _02.BankAccounts
{
    public class DepositAccount : Account, IWithdrawMoney
    {
        public DepositAccount(Customer accountOwner, decimal balance, decimal interestRate)
            : base(accountOwner, balance, interestRate)
        {

        }

        public override decimal CalculateInterestAmountForAPeriod(int months)
        {
            if (this.Balance >= 1000)
            {
                return (this.Balance * (this.InterestRate / 100)) * months;
            }

            else return 0;
        }

        public void Withdraw(decimal money)
        {
            this.Balance -= money;
        }
    }
}
