namespace Account
{
    // Base class (Parent class) with abstraction
    public abstract class Account
    {
        public int AccountNumber { get; }
        public double Balance { get; set; }

        public Account(int accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0; // Initialize the balance to zero when an account is created.
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please deposit a positive amount.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Please withdraw a positive amount.");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }
}
