using System;

namespace SavingsAccount
{
    public class SavingsAccount : Account.Account // Inherit from the Account class
    {
        public double InterestRate { get; }

        public SavingsAccount(int accountNumber, double interestRate) : base(accountNumber)
        {
            InterestRate = interestRate;
        }

        public double CalculateInterest()
        {
            // Calculate and return the interest using the formula: Balance * (InterestRate / 100)
            double interest = Balance * (InterestRate / 100);
            Console.WriteLine($"Interest calculated: ${interest}");
            return interest;
        }
    }
}
