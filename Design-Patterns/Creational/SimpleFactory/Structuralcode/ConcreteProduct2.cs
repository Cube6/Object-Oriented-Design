using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.SimpleFactory.Structuralcode
{
	public class ConcreteProduct2 :AbstractProduct
	{
		public override void create()
		{
			Console.WriteLine("ConcreteProduct2 created");
		}
	}
}
