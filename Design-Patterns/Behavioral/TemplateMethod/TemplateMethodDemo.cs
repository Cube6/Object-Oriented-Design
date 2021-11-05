using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod
{
	public class TemplateMethodDemo : PatternDemoBase
	{
		/*
		意图：
			The Template Method design pattern defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. This pattern lets subclasses redefine certain steps of an algorithm without changing the algorithm‘s structure.
			定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。TemplateMethod使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。

		场景：
			 一次性实现一个算法的不变的部分，并将可变的行为留给子类来实现。
			 各子类中公共的行为应被提取出来并集中到一个公共父类中以避免代码重复。这是Opdyke和Johnson所描述过的“重分解以一般化”的一个很好的例子。首先识别现有代码中的不同之处，并且将不同之处分离为新的操作。最后，用一个调用这些新的操作的模板方法来替换这些不同的代码。
			 控制子类扩展。模板方法只在特定点调用“hook ”操作，这样就只允许在这些点进行扩展。

		 * */
		public override string PatternName => "Template Pattern";

		protected override void RunImpl()
		{
			AbstractClass concreteClassA = new ConcreteClassA();
			concreteClassA.TemplateMethod();

			AbstractClass concreteClassB = new ConcreteClassA();
			concreteClassB.TemplateMethod();

			/* Sample */
			Sample.HummerH1Model h1 = new Sample.HummerH1Model();
			h1.SetAlarm(false);
			h1.Run();

			Sample.HummerH2Model h2 = new Sample.HummerH2Model();
			h2.Run();
		}
	}
}
