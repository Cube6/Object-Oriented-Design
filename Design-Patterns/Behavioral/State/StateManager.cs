using System;

namespace Design_Patterns
{
	public class StateManager
	{
        public static void Process(string[] args)
        {
            // Open a new account
            Account account = new Account("Jim Johnson");
            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            // Wait for user
            Console.ReadKey();
        }
    }
}
