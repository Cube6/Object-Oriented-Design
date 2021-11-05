using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Open_Closed_Principle.GoodSample
{
	public class GraphicEditor
	{
		public void DrawAllShapes(IList<Shape> shapes)
		{
			foreach (var shape in shapes)
			{
				shape.Draw();
			}
		}
	}
}
