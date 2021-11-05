using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Open_Closed_Principle.GoodSample
{
	public class Circle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Draw Circle");
		}
	}
}
