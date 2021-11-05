using System;
using System.Collections.Generic;

namespace Design_Patterns.Behavioral.Visitor.Sample
{
	public class Employees
	{
		private List<Employee> employees = new List<Employee>();

		public void Attach(Employee employee)
		{
			employees.Add(employee);
		}

		public void Detach(Employee employee)
		{
			employees.Remove(employee);
		}

		public void Aaccept(IVisitor visitor)
		{
			foreach (Employee employee in employees)
			{
				employee.Accept(visitor);
			}

			Console.WriteLine();
		}
	}
}
