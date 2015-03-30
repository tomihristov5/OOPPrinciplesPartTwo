// Problem 2. Bank accounts
// A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
// Customers could be individuals or companies.
// All accounts have customer, balance and interest rate (monthly based).
// Deposit accounts are allowed to deposit and with draw money.
// Loan and mortgage accounts can only deposit money.
// All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as 
// follows: number_of_months * interest_rate.
// Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held 
// by a company.
// Deposit accounts have no interest if their balance is positive and less than 1000.
// Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for 
// individuals.
// Your task is to write a program to model the bank system by classes and interfaces.
// You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the 
// interest functionality through overridden methods.

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
