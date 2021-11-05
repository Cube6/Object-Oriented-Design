using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Open_Closed_Principle.BadSample
{
	public class Circle : Shape
	{
		public double Radius;
		public Point Center;

		public Circle()
		{
			Type = ShapeType.Circle;
		}
	}
}
