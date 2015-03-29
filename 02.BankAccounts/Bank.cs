namespace _02.BankAccounts
{
    using System.Collections.Generic;

    public class Bank
    {
        private List<Account> listOfAccounts;

        public Bank()
        {
            this.listOfAccounts = new List<Account>();
        }

        public List<Account> ListOfAccounts
        {
            get { return this.listOfAccounts; }
        }

        public void AddAccount(Account newAccount)
        {
            listOfAccounts.Add(newAccount);
        }

        public void RemoveAccount(Account oldAccount)
        {
            listOfAccounts.Remove(oldAccount);
        }
    }
}
