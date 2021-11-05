using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.SimpleFactory.Structuralcode
{
	public abstract class AbstractProduct
	{
		public virtual void create()
		{
			Console.WriteLine("AbstractProduct created");
		}
	}
}
