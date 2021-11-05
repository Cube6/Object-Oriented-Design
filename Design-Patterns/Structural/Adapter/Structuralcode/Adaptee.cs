using System;

namespace Design_Patterns.Structural.Adapter.Structuralcode
{
	public class Adaptee
	{
		public void SpecificRequest()
		{
			Console.WriteLine("Called SpecificRequest()");
		}
	}
}
