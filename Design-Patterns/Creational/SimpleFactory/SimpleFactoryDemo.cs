using Design_Patterns.Creational.SimpleFactory.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.SimpleFactory
{
	public class SimpleFactoryDemo
	{
		//design pattern 原则:封装变化点

		//simple factory 

		//动机(motivation)
		//解决new 的实现依赖

		//比如，一个类要经常被创建，创建起来很麻烦(一系列相关的逻辑要做)，而且创建的逻辑也可能改动，这时候我们就可以用简单工厂去解决它。

		
		public void Run()
		{
			var worker=WheelFactory.CreateWheel(WheelType.Changan);
			worker.Create();
		}
	}
}
