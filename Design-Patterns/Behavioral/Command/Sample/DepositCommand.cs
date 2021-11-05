using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command.Sample
{
	public class DepositCommand : Command
	{
		private readonly BankAccount _account;
		private readonly decimal _amount;

		public DepositCommand(BankAccount account,decimal amount)
		{
			Id = Guid.NewGuid();
			CreateOn = DateTime.UtcNow;
			Status = CommandState.Unprocessed;

			_account = account;
			_amount = amount;
		}

		public override void Execute()
		{
			_account.Balance += _amount;

			Status = CommandState.ExecuteSucceeded;
		}

		public override void Undo()
		{
			if (_account.Balance >= _amount)
			{
				_account.Balance -= _amount;

				Status = CommandState.UndoSucceeded;
			}
			else
			{
				Status = CommandState.UndoFailed;
			}
		}
	}
}
