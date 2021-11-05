using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype.Sample
{
	public class Employee
	{
		public string Name { get; set; }

		public Employee Clone()
		{
			return (Employee)this.MemberwiseClone();
		}
	}
}
