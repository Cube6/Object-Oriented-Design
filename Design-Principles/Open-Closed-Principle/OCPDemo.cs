using Design_Principles.Open_Closed_Principle.BadSample;
using Design_Principles.Open_Closed_Principle.GoodSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Open_Closed_Principle
{
	public class OCPDemo
	{
		public static void Run()
		{
			GraphicEditorBadSample.Run();

			GraphicEditorGoodSample.Run();
		}
	}
}
