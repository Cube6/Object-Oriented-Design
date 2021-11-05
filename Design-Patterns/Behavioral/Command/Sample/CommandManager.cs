using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command.Sample
{
	public class CommandManager
	{
		private readonly List<Command> commands = new List<Command>();

		public bool HasPendingTransactions=> commands.Any(x =>
                    x.Status == CommandState.Unprocessed ||
                    x.Status == CommandState.ExecuteFailed ||
                    x.Status == CommandState.UndoFailed);

		public void AddCommand(Command command)
		{
			commands.Add(command);
		}

		public void ProcessPendingCommands()
		{
			commands.Where(c => 
			c.Status ==CommandState.Unprocessed || 
			c.Status == CommandState.ExecuteFailed).ToList().ForEach(pc => pc.Execute());

			commands.Where(x =>
				x.Status == CommandState.UndoFailed).ToList().ForEach(undo => undo.Undo());
		}

		public void UndoTransactionNumber(Guid id)
		{
			// Get the Command object that has the passed ID.
			// If it does not exist in commands, the result will be null (default, for this object type).
			Command transaction = commands.FirstOrDefault(x => x.Id == id);

			if (transaction == null)
			{
				throw new ArgumentException(string.Format("There is no transaction number: {0}", id));
			}

			if (transaction.Status != CommandState.ExecuteSucceeded)
			{
				throw new ArgumentException("Can only undo transactions that have been successfully executed.");
			}

			// We have a valid command, so perform the "undo".
			transaction.Undo();

			// Remove the command, if it was successfully completed.
			if (transaction.Status == CommandState.UndoSucceeded)
			{
				commands.Remove(transaction);
			}
		}

		public void RemoveOldTransactions()
		{
			// Remove transaction that have been Executed, and are more than 15 days old.
			commands.RemoveAll(x =>
				x.Status == CommandState.ExecuteSucceeded &&
			(DateTime.UtcNow - x.CreateOn).Days > 15);
		}

		//		questions:
		//Will we want to undo all Commands, or only selected Commands?
		//If it’s only selected Commands, how will we know which ones to undo?
		//We’ll probably need a unique ID for each Command object, which means we need to define an ID property in ITransaction.

		//We’ll also want to only undo Commands that were successfully completed.
		//If we undo a Command, does that mean we can run Execute on it again?
		//Or, should we only be able to delete it?
		//Do we need another Boolean property, to show if the Undo was completed?
		//Maybe we need a CommandStatus enumerator, with values for all possible states of the Command object.

		//What criteria should we use to delete a Command from the TransactionManager object?
		//If we want to call the Undo function on some Commands, we can’t delete the Command objects after the Execute is successful.

		//      Answer:
		//We want to Undo a Command based on an ID.
		//You can only Undo a Command if the Execute was completed.
		//If the Undo fails, set the Command’s status to UndoFailed – so we can retry the Undo again.
		//If the Undo succeeds, set the Command’s status to UndoSucceeded – so we can delete it.We do not want to allow the user to call Execute again, after an Undo.
		//We will delete all completed Commands over 15 days old. So, we also need a date property in ITransaction.


	}
}
