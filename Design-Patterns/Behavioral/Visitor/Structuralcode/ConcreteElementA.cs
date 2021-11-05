namespace Design_Patterns.Behavioral.Visitor.Structuralcode
{
	public class ConcreteElementA : Element
	{
		public override void Accept(Visitor visitor)
		{
			visitor.VisitConcreteElementA(this);
		}

		public void OperationA()
		{

		}
	}
}
