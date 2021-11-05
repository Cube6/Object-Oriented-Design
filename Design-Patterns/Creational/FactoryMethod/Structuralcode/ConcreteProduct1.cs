using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.FactoryMethod.Structuralcode
{
	public class ConcreteProduct1:AbstractProduct
	{
		public override void create()
		{
			Console.WriteLine("ConcreteProduct1 created");
		}
	}
}
