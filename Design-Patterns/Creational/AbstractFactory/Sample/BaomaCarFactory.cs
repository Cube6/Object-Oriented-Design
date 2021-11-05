using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactory.Sample
{
	public class BaomaCarFactory:CarFactory
	{
		public override Glass CreateGlass()
		{
			var baomaCarFactory = new BaomaCarFactory();
			return baomaCarFactory.CreateGlass();
		}

		/// <summary>
		/// /XXXX
		/// </summary>
		/// <returns></returns>

		public override Wheel CreateWheel()
		{
			var baomaWheelFactory = new BaomaWheelFactory();
			return baomaWheelFactory.CreateWheel();
		}
	}
}
