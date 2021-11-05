using System;

namespace Design_Patterns
{
    public class RedState : State
    {
        private double serviceFee;
        // Constructor
        public RedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();
        }
        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            serviceFee = 15.00;
        }
        public override void Handle(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }
        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
                account.State.Handle(balance);
            }
			else
			{
               //ending
			}
        }
    }
}
