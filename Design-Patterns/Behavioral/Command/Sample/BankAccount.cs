using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command.Sample
{
    public class BankAccount
    {
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string ownerName, decimal balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }
    }
}
