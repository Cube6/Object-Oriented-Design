using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Open_Closed_Principle.BadSample
{
	public class Square : Shape
	{
		public double side;
		public Point TopLeft;

		public Square()
		{
			Type = ShapeType.Square;
		}
	}
}
