using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod
{
	public abstract class AbstractClass
	{
		protected abstract void PrimitiveOperation1();
		protected abstract void PrimitiveOperation2();

		public void TemplateMethod()
		{
			PrimitiveOperation1();
			PrimitiveOperation2();
		}
	}
}
