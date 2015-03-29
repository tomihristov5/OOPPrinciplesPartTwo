namespace _02.BankAccounts
{
    using System;

    public static class BankSystemTest
    {
        static void Main()
        {
            Bank newBank = new Bank();

            DepositAccount pesho = new DepositAccount(new Individuals("Pesho Ivanov"), 5000, 2.5m);
            LoanAccount gosho = new LoanAccount(new Individuals("Gosho Petrov"), 1000, 12.7m);
            LoanAccount yula = new LoanAccount(new Company("Yula OOD"), 100000, 10.5m);
            MortgageAccount tosho = new MortgageAccount(new Individuals("Tosho Kovachev"), 50000, 6.7m);
            DepositAccount trisko = new DepositAccount(new Company("Trisko AD"), 500000, 2.3m);

            newBank.AddAccount(pesho);
            newBank.AddAccount(trisko);

            Console.WriteLine(pesho.AccountOwner.CustomerName + "'s interest for the given period is: "
                + pesho.CalculateInterestAmountForAPeriod(5));
            Console.WriteLine(gosho.AccountOwner.CustomerName + "'s interest for the given period is: " 
                + gosho.CalculateInterestAmountForAPeriod(2));
            Console.WriteLine(yula.AccountOwner.CustomerName + "'s interest for the given period is: " 
                + yula.CalculateInterestAmountForAPeriod(8));
            Console.WriteLine(tosho.AccountOwner.CustomerName + "'s interest for the given period is: "
                + tosho.CalculateInterestAmountForAPeriod(16));
            Console.WriteLine(trisko.AccountOwner.CustomerName + "'s interest for the given period is: " 
                + trisko.CalculateInterestAmountForAPeriod(14));

            pesho.Withdraw(300);
            Console.WriteLine(pesho.AccountOwner.CustomerName + "'s balance is: " + pesho.Balance);

            gosho.Deposit(4000);
            Console.WriteLine(gosho.AccountOwner.CustomerName + "'s balance is: " + gosho.Balance);
        }
    }
}
