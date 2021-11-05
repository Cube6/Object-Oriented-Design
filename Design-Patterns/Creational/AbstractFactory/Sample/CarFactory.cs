using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactory.Sample
{
	public abstract class CarFactory
	{
		public abstract Glass CreateGlass();

		//XXX//

		public abstract Wheel CreateWheel();
	}
}
