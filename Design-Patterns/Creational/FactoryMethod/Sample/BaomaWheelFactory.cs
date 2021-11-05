using System;

namespace Design_Patterns.Creational.FactoryMethod.Sample
{
	public class BaomaWheelFactory : IWheelFactory
	{
		public Wheel CreateWheel()
		{
			return new BaomaWheel();
		}
	}
}
