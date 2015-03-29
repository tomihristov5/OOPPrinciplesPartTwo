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

            Console.WriteLine("{0}'s interest for the given period is: {1:0.00}",
                pesho.AccountOwner.CustomerName, trisko.CalculateInterestAmountForAPeriod(5));
            Console.WriteLine("{0}'s interest for the given period is: {1:0.00}",
                gosho.AccountOwner.CustomerName, trisko.CalculateInterestAmountForAPeriod(2));
            Console.WriteLine("{0}'s interest for the given period is: {1:0.00}",
                yula.AccountOwner.CustomerName, trisko.CalculateInterestAmountForAPeriod(8));
            Console.WriteLine("{0}'s interest for the given period is: {1:0.00}",
                tosho.AccountOwner.CustomerName, trisko.CalculateInterestAmountForAPeriod(16));
            Console.WriteLine("{0}'s interest for the given period is: {1:0.00}", 
                trisko.AccountOwner.CustomerName, trisko.CalculateInterestAmountForAPeriod(14));

            pesho.Withdraw(300);
            Console.WriteLine("{0}'s balance is: {1:0.00}", pesho.AccountOwner.CustomerName, pesho.Balance);

            gosho.Deposit(4000);
            Console.WriteLine("{0}'s balance is: {1:0.00}", gosho.AccountOwner.CustomerName, gosho.Balance);
        }
    }
}
