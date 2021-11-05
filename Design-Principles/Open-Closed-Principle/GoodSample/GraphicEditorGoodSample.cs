using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Open_Closed_Principle.GoodSample
{
	public class GraphicEditorGoodSample
	{
		public static void Run()
		{
			var shapes = new List<Shape>();
			shapes.Add(new Circle());
			shapes.Add(new Square());

			var editor = new GraphicEditor();
			editor.DrawAllShapes(shapes);
		}
	}
}
