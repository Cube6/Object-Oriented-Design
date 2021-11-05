namespace Design_Patterns.Structural.Adapter.Structuralcode
{
	public class Adapter : Target
	{
		private Adaptee adaptee = new Adaptee();

		public override void Request()
		{
			adaptee.SpecificRequest();
		}
	}
}
