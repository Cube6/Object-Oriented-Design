using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactory.Sample
{
	public class ChanganWheelFactory:IWheel
	{
		public Wheel CreateWheel()
		{
			return new ChanganWheel();
		}
	}
}
