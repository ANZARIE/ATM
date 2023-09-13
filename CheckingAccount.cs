namespace CheckingAccount
{
    public class CheckingAccount : Account.Account // Inherit from the Account class
    {
        public double OverdraftLimit { get; }

        public CheckingAccount(int accountNumber, double overdraftLimit) : base(accountNumber)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0)
            {
                double availableBalance = Balance + OverdraftLimit; // Calculate available balance including overdraft limit
                if (amount <= availableBalance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
                }
                else
                {
                    Console.WriteLine("Withdrawal amount exceeds available balance (including overdraft limit).");
                }
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Please withdraw a positive amount.");
            }
        }
    }
}
