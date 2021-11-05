using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command.Sample
{
	public class BankAccount_NonCommand
	{
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount_NonCommand(string ownerName, decimal balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("Overdraft error");
            }

            Balance -= amount;
        }


        //Sometimes, you don’t want to do execute your functions immediately.
        //You can use the Command pattern to add work to a queue, to be done later.
        //You can use it to retry, if a command cannot execute properly.
        //You might be able to use this to add “undo” capabilities to a program.

    }
}
