using System;

namespace Design_Patterns.Behavioral.Visitor.Structuralcode
{
	public class ConcreteVisitor2 : Visitor
	{
		public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
		{
			Console.WriteLine("{0} visited by {1}", concreteElementA.GetType().Name, this.GetType().Name);
		}

		public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
		{
			Console.WriteLine("{0} visited by {1}", concreteElementB.GetType().Name, this.GetType().Name);
		}
	}
}
