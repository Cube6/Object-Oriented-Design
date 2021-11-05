using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype.Structuralcode
{
	public class ConcretePrototype2 : AbstractPrototype
	{
		public ConcretePrototype2()
		{
		}

		public override AbstractPrototype Clone()
		{
			return (AbstractPrototype)this.MemberwiseClone();
		}

	}
}
