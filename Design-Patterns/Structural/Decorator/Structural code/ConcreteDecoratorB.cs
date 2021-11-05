using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator
{
	public class ConcreteDecoratorB : Decorator
	{
		public override void Operation()
		{
			base.Operation();
			Console.WriteLine("ConcreteDecoratorB.Operation");
		}
	}
}
