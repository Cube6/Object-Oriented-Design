using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command.Sample
{
	public class TransferCommand : Command
	{
		private readonly decimal _amount;
		private readonly BankAccount _fromAccount;
		private readonly BankAccount _toAccount;


		public TransferCommand(BankAccount fromAccount, BankAccount toAccount, decimal amount)
		{
			Id = Guid.NewGuid();
			CreateOn = DateTime.UtcNow;
			Status = CommandState.Unprocessed;

			_fromAccount = fromAccount;
			_toAccount = toAccount;
			_amount = amount;
		}

		public override void Execute()
		{
			if (_fromAccount.Balance >= _amount)
			{
				_fromAccount.Balance -= _amount;
				_toAccount.Balance += _amount;

				Status = CommandState.ExecuteSucceeded;
			}
		}

		public override void Undo()
		{
			if (_toAccount.Balance >= _amount)
			{
				_toAccount.Balance -= _amount;
				_fromAccount.Balance += _amount;

				Status = CommandState.UndoSucceeded;
			}
			else
			{
				Status = CommandState.UndoFailed;
			}
		}
	}
}
