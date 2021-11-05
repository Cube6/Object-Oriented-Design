using Design_Patterns.Behavioral.Visitor.Structuralcode;

namespace Design_Patterns.Behavioral.Visitor
{
	/*
     * Motivation:
     *      Collections are data types widely used in object oriented programming. 
     *  Often collections contain objects of different types and in those cases some operations have to be performed on all the collection elements without knowing the type.
     *      A possible approach to apply a specific operation on objects of different types in a collection would be the use if blocks in conjunction with 'instanceof' for each element. 
     *  This approach is not a nice one, not flexible and not object oriented at all. 
     *  At this point we should think to the Open Close principle and we should remember from there that we can replace if blocks with an abstract class and each concrete class will implement its own operation.
     *  集合是在面向对象编程中广泛使用的数据类型。通常集合包含不同类型的对象，在这种情况下，必须在不知道类型的情况下对所有集合元素执行某些操作。
     *  对集合中不同类型的对象应用特定操作的一种可能方法是将if块与每个元素的instanceof结合使用。这种方法不太好，不灵活，也不面向对象。
     *  在这一点上，我们应该考虑开-关原则，我们应该记住，从那里我们可以用一个抽象类替换if块，每个具体类将实现自己的操作。
     *  
     * Intent:
     *      Represents an operation to be performed on the elements of an object structure.
     *  Visitor lets you define a new operation without changing the classes of the elements on which it operates.
     *  表示要对对象结构的元素执行的操作。Visitor允许您定义一个新的操作，而无需更改它所操作的元素的类。
     */
	public class VisitorStructuralDemo : PatternDemoBase
	{
		public override string PatternName => "Visitor (Structured)";

		protected override void RunImpl()
		{
			ObjectStructure o = new ObjectStructure();
			o.Attach(new ConcreteElementA());
			o.Attach(new ConcreteElementB());

			ConcreteVisitor1 v1 = new ConcreteVisitor1();
			ConcreteVisitor2 v2 = new ConcreteVisitor2();

			o.Accept(v1);
			o.Accept(v2);

		}
	}
}
