using Design_Patterns.Behavioral.Command;
using Design_Patterns.Behavioral.Observer;
using Design_Patterns.Behavioral.Strategy;
using Design_Patterns.Behavioral.TemplateMethod;
using Design_Patterns.Behavioral.Visitor;
using Design_Patterns.Creational.AbstractFactory;
using Design_Patterns.Creational.AbstractFactory.Sample;
using Design_Patterns.Creational.FactoryMethod;
using Design_Patterns.Creational.Prototype;
using Design_Patterns.Creational.SimpleFactory;
using Design_Patterns.Structural.Adapter;
using Design_Patterns.Structural.Decorator;
using System;

namespace Design_Patterns
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello Design-Patterns!");

			#region Observer

			var observerDemo = new ObserverDemo();
			observerDemo.Run();

			#endregion

			#region TemplateMethod

			var templatedMethodDemo = new TemplateMethodDemo();
			templatedMethodDemo.Run();

			#endregion
			//var decoratorDemo = new DecoratorDemo();
			//decoratorDemo.Run();

			#region Visitor Structural Demo and Real World Demo

			var visitorStructuralDemo = new VisitorStructuralDemo();
			visitorStructuralDemo.Run();

			var visitorRealWorldDemo = new VisitorRealWordDemo();
			visitorRealWorldDemo.Run();

			#endregion Visitor Structural Demo and Real Word Demo

			#region Adapter
			var adapterStructuralDemo = new AdapterStructuralDemo();
			adapterStructuralDemo.Run();

			var adapterRealWorldDemo = new AdapterRealWordDemo();
			adapterRealWorldDemo.Run();
			#endregion Adapter

			#region Factory

			SimpleFactoryDemo simpleFactoryDemo = new SimpleFactoryDemo();
			simpleFactoryDemo.Run();

			FactoryMethodDemo factoryMethodDemo = new FactoryMethodDemo();
			factoryMethodDemo.Run();

			ChanganCarFactory changanCarFactory = new ChanganCarFactory();
			AbstractFactoryDemo abstractFactoryDemo = new AbstractFactoryDemo(changanCarFactory);
			abstractFactoryDemo.Run();

			#endregion

			#region Prototype

			PrototypeDemo prototypeDemo = new PrototypeDemo();
			prototypeDemo.Run();

			#endregion

			#region Decorator

			DecoratorDemo decoratorDemo = new DecoratorDemo();
			decoratorDemo.Run();

			#endregion

			#region Strategy
			var strategyDemo = new StrategyPatternDemo();
			strategyDemo.Run();
			#endregion Strategy

			#region Command

			CommandDemo commandDemo = new CommandDemo();
			commandDemo.Run();

			#endregion

			Console.ReadLine();
		}
	}
}
