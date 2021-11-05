using System;

namespace Design_Patterns.Creational.FactoryMethod.Sample
{
	public class ChanganWheelFactory : IWheelFactory
	{
		public Wheel CreateWheel()
		{
			return new ChanganWheel();
		}
	}
}
