using Design_Patterns.Structural.ProxyPattern.Sample;
using Design_Patterns.Structural.ProxyPattern.Structural_code;
using System;

namespace Design_Patterns.Structural.ProxyPattern
{
	class ProxyDemo : PatternDemoBase
	{
		/*
		 意图：
			The Proxy design pattern provides a surrogate or placeholder for another object to control access to it.
			为其他对象提供一种代理以控制对这个对象的访问。
		场景：
			在需要用比较通用和复杂的对象指针代替简单的指针的时候，使用Proxy模式。
			下面是一些可以使用Proxy模式常见情况：
				 远程代理（Remote Proxy ）为一个对象在不同的地址空间提供局部代表。
				 虚代理（Virtual Proxy ）根据需要创建开销很大的对象。
				 保护代理（Protection Proxy ）控制对原始对象的访问。保护代理用于对象应该有不同的访问权限的时候。
				 智能指引（Smart Reference ）取代了简单的指针，它在访问对象时执行一些附加操作。
			它的典型用途包括：
				 对指向实际对象的引用计数，这样当该对象没有引用时，可以自动释放它。
				 当第一次引用一个持久对象时，将它装入内存。
				 在访问一个实际对象前，检查是否已经锁定了它，以确保其他对象不能改变它。
		 */

		public override string PatternName => "Proxy Pattern";

		protected override void RunImpl()
		{
			#region Structural code

			Client client = new Client();

			Console.WriteLine("Client: Executing the client code with a real subject:");
			RealSubject realSubject = new RealSubject();
			client.ClientCode(realSubject);

			Console.WriteLine();

			Console.WriteLine("Client: Executing the same client code with a proxy:");
			Proxy proxy = new Proxy(realSubject);
			client.ClientCode(proxy);

			/***********************Output*******************************
				Client: Executing the client code with a real subject:
				RealSubject: Handling Request.

				Client: Executing the same client code with a proxy:
				Proxy: Checking access prior to firing a real request.
				RealSubject: Handling Request.
				Proxy: Logging the time of request.
			**************************************************************/

			#endregion

			#region Sample

			var tvService = new TencentVideoService();

			var tvProxy = new CachedVideoService(tvService);

			var manager = new VideoManager(tvProxy);

			long videoId = 10; //Get From User's input
			manager.ReactOnUserInput(videoId);

			#endregion
		}
	}
}