using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype.Structuralcode
{
	public class ConcretePrototype1 :AbstractPrototype
	{
		public ConcretePrototype1()
		{
		}

		public override AbstractPrototype Clone()
		{
			return (AbstractPrototype)this.MemberwiseClone();
		}

	}
}
