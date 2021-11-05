namespace Design_Patterns.Behavioral.Visitor.Structuralcode
{
	public class ConcreteElementB : Element
	{
		public override void Accept(Visitor visitor)
		{
			visitor.VisitConcreteElementB(this);
		}

		public void OperationB()
		{

		}
	}
}
