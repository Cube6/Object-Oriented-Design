using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Open_Closed_Principle.GoodSample
{
	public class Square : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Draw Square");
		}
	}
}
