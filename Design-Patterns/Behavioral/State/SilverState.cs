using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// namespace Design_Patterns
namespace Design_Patterns
{
    public class SilverState : State
    {
        // Overloaded constructors
        public SilverState(State state) :
            this(state.Balance, state.Account)
        {
        }
        public SilverState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }
        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }
        public override void Handle(double amount)
        {
            balance += amount;
            ChangeState(balance);
        }
        private void ChangeState(double amount)
        {
            if (balance < lowerLimit)
            {
                account.State = new RedState(this);
                account.State.Handle(amount);
            }
            else if (balance > upperLimit)
            {
                account.State = new GoldState(this);
                account.State.Handle(amount);
            }
        }
    }
}
