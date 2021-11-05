using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod
{
	public class ConcreteClassB : AbstractClass
	{
		protected override void PrimitiveOperation1()
		{
			Console.WriteLine("ConcreteClassB.PrimitiveOperation1");
		}

		protected override void PrimitiveOperation2()
		{
			Console.WriteLine("ConcreteClassB.PrimitiveOperation2");
		}
	}
}
