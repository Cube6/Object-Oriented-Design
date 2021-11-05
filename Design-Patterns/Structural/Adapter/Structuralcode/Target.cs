using System;

namespace Design_Patterns.Structural.Adapter.Structuralcode
{
	public class Target
	{
		public virtual void Request()
		{
			Console.WriteLine("Called Target Request()");
		}
	}
}
