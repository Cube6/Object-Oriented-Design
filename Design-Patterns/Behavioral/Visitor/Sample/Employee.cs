namespace Design_Patterns.Behavioral.Visitor.Sample
{
	public class Employee : Element
	{
		private string name;
		private double income;
		private int vacationDays;

		public Employee(string name, double income, int vacationDays)
		{
			this.name = name;
			this.income = income;
			this.vacationDays = vacationDays;
		}

		public string Name { get => name; set => name = value; }
		public double Income { get => income; set => income = value; }
		public int VacationDays { get => vacationDays; set => vacationDays = value; }

		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
