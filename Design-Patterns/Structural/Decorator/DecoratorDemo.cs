using Design_Patterns.Structural.Decorator.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator
{
	public class DecoratorDemo : PatternDemoBase
	{
		/*
		 意图：
			The Decorator design pattern attaches additional responsibilities to an object dynamically. This pattern provide a flexible alternative to subclassing for extending functionality.
			动态地给一个对象添加一些额外的职责。就增加功能来说，Decorator模式相比生成子类更为灵活。
		场景：
			 在不影响其他对象的情况下，以动态、透明的方式给单个对象添加职责。
			 处理那些可以撤消的职责。
			 当不能采用生成子类的方法进行扩充时。一种情况是，可能有大量独立的扩展，为支持每一种组合将产生大量的子类，使得子类数目呈爆炸性增长。另一种情况可能是因为类定义被隐藏，或类定义不能用于生成子类。
		 */

		public override string PatternName => "Decorator Pattern";

		protected override void RunImpl()
		{
			/* Structural code */
			ConcreteComponent component = new ConcreteComponent();

			ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
			ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();

			decoratorA.SetComponent(component);
			decoratorB.SetComponent(decoratorA);

			decoratorB.Operation();

			//Sample
			SchoolReport report = new FouthGradeSchoolReport();

			report = new HighestScoreDecorator(report);
			report = new RankDecorator(report);

			report.Report();
		}
	}
}
