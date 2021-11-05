namespace Design_Patterns.Behavioral.Visitor.Structuralcode
{
	public abstract class Visitor
	{
		public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
		public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
	}
}
