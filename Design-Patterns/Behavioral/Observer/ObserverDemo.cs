using System;

namespace Design_Patterns.Behavioral.Observer
{

	public class ObserverDemo : PatternDemoBase
	{
		/*
		意图：
			The Observer design pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
			定义对象间的一种一对多的依赖关系,当一个对象的状态发生改变时, 所有依赖于它的对象都得到通知并被自动更新。
		场景：
			 当一个抽象模型有两个方面, 其中一个方面依赖于另一方面。将这二者封装在独立的对象中以使它们可以各自独立地改变和复用。
			 当对一个对象的改变需要同时改变其它对象, 而不知道具体有多少对象有待改变。
			 当一个对象必须通知其它对象，而它又不能假定其它对象是谁。换言之, 你不希望这些对象是紧密耦合的。
		 */
		public override string PatternName => "Observer Pattern";

		protected override void RunImpl()
		{
			/* Structural code */

			// Configure Observer pattern
			ConcreteSubject subject = new ConcreteSubject();

			subject.Attach(new ConcreteObserver(subject, "X"));
			subject.Attach(new ConcreteObserver(subject, "Y"));
			subject.Attach(new ConcreteObserver(subject, "Z"));

			// Change subject and notify observers
			subject.SubjectState = "ABC";
			subject.Notify();

			/* Sample */
			NewsPublisher publisher = new BusinessNewsPublisher();
			publisher.Attach(new SMSSubscriber());
			publisher.Attach(new EmailSubscriber());

			publisher.AddNews($"News1 {DateTime.Now.ToString()}");

			publisher.Notify();
		}
	}
}
