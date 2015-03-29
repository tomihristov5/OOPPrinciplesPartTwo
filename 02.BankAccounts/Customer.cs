namespace _02.BankAccounts
{
    public abstract class Customer
    {
        private string customerName;

        public Customer(string customerName)
        {
            this.CustomerName = customerName;
        }

        public string CustomerName
        {
            get
            {
                return this.customerName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Customer must have a name!");
                }

                this.customerName = value;
            }
        }
    }
}
