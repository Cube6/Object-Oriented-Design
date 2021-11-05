using System;

namespace Design_Patterns.Behavioral.Memento.Sample
{
	public class SalesProspect
	{
		string name;
		string phone;
		double budget;
		// Gets or sets name
		public string Name
		{
			get { return name; }
			set
			{
				name = value;
				Console.WriteLine("Name:   " + name);
			}
		}
		// Gets or sets phone
		public string Phone
		{
			get { return phone; }
			set
			{
				phone = value;
				Console.WriteLine("Phone:  " + phone);
			}
		}
		// Gets or sets budget
		public double Budget
		{
			get { return budget; }
			set
			{
				budget = value;
				Console.WriteLine("Budget: " + budget);
			}
		}
		// Stores memento
		public Memento SaveMemento()
		{
			Console.WriteLine("\nSaving state --\n");
			return new Memento(name, phone, budget);
		}
		// Restores memento
		public void RestoreMemento(Memento memento)
		{
			Console.WriteLine("\nRestoring state --\n");
			Name = memento.Name;
			Phone = memento.Phone;
			Budget = memento.Budget;
		}
	}
}
