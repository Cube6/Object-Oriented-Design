using System;

namespace Design_Patterns.Behavioral.Observer
{
	public class ConcreteObserver : Observer
	{
		private string name;
		private string observerState;
		private ConcreteSubject subject;
		// Constructor
		public ConcreteObserver(
			ConcreteSubject subject, string name)
		{
			this.subject = subject;
			this.name = name;
		}

		public override void Update()
		{
			observerState = subject.SubjectState;
			Console.WriteLine("Observer {0}'s new state is {1}",
				name, observerState);
		}
		// Gets or sets subject
		public ConcreteSubject Subject
		{
			get { return subject; }
			set { subject = value; }
		}
	}
}
