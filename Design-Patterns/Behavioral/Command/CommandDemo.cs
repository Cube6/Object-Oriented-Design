using Design_Patterns.Behavioral.Command.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command
{
	public class CommandDemo : PatternDemoBase
	{
		public override string PatternName => "Command Pattern";

		protected override void RunImpl()
		{
            CommandManager commandManager = new CommandManager();

            BankAccount testAccount = new BankAccount("LeBron Wu", 0);

            DepositCommand deposit = new DepositCommand(testAccount, 100);
            commandManager.AddCommand(deposit);

            Console.WriteLine("One Deposit Command has been added to the queue, but not executed.");
            Console.WriteLine("The balance of this account {0} is {1} now.", testAccount.OwnerName,testAccount.Balance);
            Console.WriteLine();
            // This executes the commands.
            commandManager.ProcessPendingCommands();

            Console.WriteLine("Last Deposit Command has been executed.");
            Console.WriteLine("The balance of this account {0} is {1} now.", testAccount.OwnerName, testAccount.Balance);
            Console.WriteLine();
            // Add a withdrawal, apply it, and verify the balance changed.
            WithDrawCommand withdrawal = new WithDrawCommand(testAccount, 50);
            commandManager.AddCommand(withdrawal);

            Console.WriteLine("One WithDraw Command has been added to the queue, but not executed.");
            Console.WriteLine("The balance of this account {0} is {1} now.", testAccount.OwnerName, testAccount.Balance);
            Console.WriteLine();

            commandManager.ProcessPendingCommands();

            Console.WriteLine("Last WithDraw Command has been executed.");
            Console.WriteLine("The balance of this account {0} is {1} now.", testAccount.OwnerName, testAccount.Balance);
            Console.WriteLine();
            // Test the undo
            commandManager.UndoTransactionNumber(withdrawal.Id);

            Console.WriteLine("Last WithDraw Command has been undoed.");
            Console.WriteLine("The balance of this account {0} is {1} now.", testAccount.OwnerName, testAccount.Balance);

        }
	}
}
