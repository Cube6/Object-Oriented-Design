using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod.Sample
{
	public class HummerH1Model : HummerModel
	{
		private bool _isAlarm = true;
		protected override void Start()
		{
			Console.WriteLine("H1 Model start");
		}

		protected override void Stop()
		{
			Console.WriteLine("H1 Model stop");
		}

		protected override void Alarm()
		{
			Console.WriteLine("H1 Model alarm");
		}

		protected override void EngineBoom()
		{
			Console.WriteLine("H1 Model engine boom");
		}

		protected override bool IsAlarm()
		{
			return _isAlarm;
		}

		public void SetAlarm(bool isAlarm)
		{
			_isAlarm = isAlarm;
		}
	}
}
