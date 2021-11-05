using System;

namespace Design_Patterns
{
    public class GoldState : State
    {
        // Overloaded constructors
        public GoldState(State state)
            : this(state.Balance, state.Account)
        {
        }
        public GoldState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }
        private void Initialize()
        {
            // Should come from a database
            interest = 0.05;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
        }
        public override void Handle(double amount)
        {
            balance += amount;
            StateChangeCheck(balance);
        }
        private void StateChangeCheck(double amount)
        {
            if (balance < 0.0)
            {
                account.State = new RedState(this);
                account.State.Handle(amount);
            }
            else if (balance < lowerLimit)
            {
                account.State = new SilverState(this);
                account.State.Handle(amount);
            }
        }
    }
}
