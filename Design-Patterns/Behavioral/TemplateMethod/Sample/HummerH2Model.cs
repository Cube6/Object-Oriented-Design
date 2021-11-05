using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod.Sample
{
	public class HummerH2Model : HummerModel
	{
		protected override void Start()
		{
			Console.WriteLine("H2 Model start");
		}

		protected override void Stop()
		{
			Console.WriteLine("H2 Model stop");
		}

		protected override void Alarm()
		{
			Console.WriteLine("H2 Model alarm");
		}

		protected override void EngineBoom()
		{
			Console.WriteLine("H2 Model engine boom");
		}

		protected override bool IsAlarm()
		{
			return false;
		}
	}
}
