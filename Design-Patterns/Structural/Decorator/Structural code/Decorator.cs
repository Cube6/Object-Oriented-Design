using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator
{
	public abstract class Decorator : Component
	{
		protected Component component;

		public void SetComponent(Component component)
		{
			this.component = component;
		}

		public override void Operation()
		{
			component?.Operation();
		}
	}
}
