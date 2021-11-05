using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod.Sample
{
	public abstract class HummerModel
	{
		protected abstract void Start();
		protected abstract void Stop();
		protected virtual bool IsAlarm()
		{
			return true;
		}
		protected abstract void Alarm();
		protected abstract void EngineBoom();
		public void Run()
		{
			Start();

			EngineBoom();

			if (IsAlarm())
			{
				Alarm();
			}

			Stop();
		}
	}
}
