using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Observer
{
	public class SMSSubscriber : Subscriber
	{
		public override void Update(NewsPublisher publisher)
		{
			Console.WriteLine(publisher.GetLatestNews());
		}
	}
}
