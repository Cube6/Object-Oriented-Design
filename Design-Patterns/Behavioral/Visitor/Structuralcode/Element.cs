namespace Design_Patterns.Behavioral.Visitor.Structuralcode
{
	public abstract class Element
	{
		public abstract void Accept(Visitor visitor);
	}
}
