using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.SimpleFactory.Sample
{
	public class BaomaWheel : Wheel
	{
		public BaomaWheel()
		{
		}

		public override void Create()
		{
			Console.WriteLine("BaomaWheel Create");
		}

	}
}
