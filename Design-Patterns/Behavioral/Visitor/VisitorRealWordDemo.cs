using Design_Patterns.Behavioral.Visitor.Sample;

namespace Design_Patterns.Behavioral.Visitor
{
	public class VisitorRealWordDemo : PatternDemoBase
	{
		public override string PatternName => "Visitor";

		protected override void RunImpl()
		{
			Employees employee = new Employees();
			employee.Attach(new Clerk());
			employee.Attach(new Director());
			employee.Attach(new President());

			employee.Aaccept(new IncomeVisitor());
			employee.Aaccept(new VacationVisitor());

		}
	}
}
