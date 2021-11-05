using Design_Patterns.Creational.Prototype.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype
{
	public class PrototypeDemo
	{
		public void Run()
		{
			Employee employee = new Employee();
			employee.Name = "original Name";


			Employee employee2 = employee.Clone();
			employee2.Name = "clone Name";

			Employee employee3 = employee.Clone();

			Console.WriteLine(employee.Name);
			Console.WriteLine(employee2.Name);
			Console.WriteLine(employee3.Name);
		}
	}
}
