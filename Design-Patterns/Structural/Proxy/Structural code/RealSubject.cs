using System;

namespace Design_Patterns.Structural.ProxyPattern.Structural_code
{
	/// <summary>
	// The RealSubject contains some core business logic. Usually, RealSubjects
	// are capable of doing some useful work which may also be very slow or
	// sensitive - e.g. correcting input data. A Proxy can solve these issues
	// without any changes to the RealSubject's code.
	/// </summary>
	public class RealSubject : Subject
	{
		public override void Request()
		{
			Console.WriteLine("Called RealSubject.Request()");
		}
	}
}
