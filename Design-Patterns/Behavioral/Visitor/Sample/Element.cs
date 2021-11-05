namespace Design_Patterns.Behavioral.Visitor.Sample
{
	public abstract class Element
	{
		public abstract void Accept(IVisitor visitor);
	}
}
