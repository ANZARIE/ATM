using System;

class Program
{
    static void DisplayAccountDetails(Account.Account account)
    {
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Balance: ${account.Balance}");
        Console.WriteLine();
    }

    static void Main()
    {
        // Creating a SavingsAccount
        SavingsAccount.SavingsAccount savingsAccount = new SavingsAccount.SavingsAccount(1001, 5); // Account number: 1001, Interest rate: 5%

        // Creating a CheckingAccount
        CheckingAccount.CheckingAccount checkingAccount = new CheckingAccount.CheckingAccount(2001, 1000); // Account number: 2001, Overdraft limit: $1000

        // Deposits
        savingsAccount.Deposit(500); // Deposit $500 to savings account
        checkingAccount.Deposit(700); // Deposit $700 to checking account

        // Display account details after deposit
        Console.WriteLine("After Deposits:");
        DisplayAccountDetails(savingsAccount);
        DisplayAccountDetails(checkingAccount);

        // Withdrawals
        savingsAccount.Withdraw(200); // Withdraw $200 from savings account
        checkingAccount.Withdraw(1500); // Attempt to withdraw $1500 from checking account

        // Display account details after withdrawal
        Console.WriteLine("After Withdrawals:");
        DisplayAccountDetails(savingsAccount);
        DisplayAccountDetails(checkingAccount);

        // Calculate and display interest for savings account
        double interest = savingsAccount.CalculateInterest();
        Console.WriteLine($"Interest Earned: ${interest}");

        // Utilize polymorphism to display account details
        Console.WriteLine("Polymorphic Account Details:");
        DisplayAccountDetails(savingsAccount);
        DisplayAccountDetails(checkingAccount);
    }
}
