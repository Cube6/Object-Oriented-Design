using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.SimpleFactory.Sample
{
	public static class WheelFactory
	{
		public static Wheel CreateWheel(WheelType wheelType)
		{
			switch (wheelType)
			{
				case WheelType.Baoma:
					return CreateBaomaWheel();
				case WheelType.Changan:
					return CreateChanganWheel();
				default:
					throw new NotImplementedException();
			}
		}

		private static BaomaWheel CreateBaomaWheel()
		{
			CreateScrew();
			CreateTyre();
			// maybe more logic here

			return new BaomaWheel();
		}

		private static ChanganWheel CreateChanganWheel()
		{
			CreateScrew();
			CreateTyre();
			// maybe more logic here

			return new ChanganWheel();
		}

		private static void CreateScrew()//生产螺丝钉
		{
			Console.WriteLine("Screw created");
		}

		private static void CreateTyre() //生产橡胶
		{
			Console.WriteLine("Tyre created");
		}
	}
}
