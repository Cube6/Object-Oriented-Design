using Design_Principles.Single_Responsibility_Principle.BadSample;
using Design_Principles.Single_Responsibility_Principle.GoodSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle
{
	public class SPRDemo
	{
		public void Run()
		{
			UserBadSample.Run();
			UserGoodSample.Run();
		}
	}
}
