using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype.Structuralcode
{
	public abstract class AbstractPrototype
	{
		public AbstractPrototype()
		{
		}

		public abstract AbstractPrototype Clone();

	}
}
