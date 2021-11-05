using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod
{
	public class ConcreteClassA : AbstractClass
	{
		protected override void PrimitiveOperation1()
		{
			Console.WriteLine("ConcreteClassA.PrimitiveOperation1");
		}

		protected override void PrimitiveOperation2()
		{
			Console.WriteLine("ConcreteClassA.PrimitiveOperation2");
		}
	}
}
