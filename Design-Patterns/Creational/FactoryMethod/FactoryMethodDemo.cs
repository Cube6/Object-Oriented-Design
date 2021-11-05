using Design_Patterns.Creational.FactoryMethod.Sample;
using System;

namespace Design_Patterns.Creational.FactoryMethod
{
	public class FactoryMethodDemo
	{
		public void Run()
		{
			//design pattern 原则:封装变化点

			//simple factory 

			//动机(motivation)
			//解决new 的实现依赖

			//比如，一个类要经常被创建，创建起来很麻烦(一系列相关的逻辑要做)，而且创建的逻辑也可能改动，这时候我们就可以用简单工厂去解决它。
			//如果产品逻辑一直在变化

			IWheelFactory[] products = new IWheelFactory[2];

			products[0] = new BaomaWheelFactory();
			products[1] = new ChanganWheelFactory();

			foreach (IWheelFactory creator in products)
			{
				Wheel product = creator.CreateWheel();
				Console.WriteLine("Created {0}",product.GetType().Name);
			}

		}

	}
}
