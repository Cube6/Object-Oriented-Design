using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactory.Sample
{
	public class ChanganCarFactory :CarFactory
	{
		public override Glass CreateGlass()
		{
			var changanGlassFactory = new ChanganGlassFactory();
			return changanGlassFactory.CreateGlass();
		}
		public override Wheel CreateWheel()
		{
			var changanWheelFactory = new ChanganWheelFactory();
			return changanWheelFactory.CreateWheel();
		}
	}
}
