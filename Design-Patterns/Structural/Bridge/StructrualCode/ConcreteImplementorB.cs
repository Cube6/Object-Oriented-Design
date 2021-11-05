/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>

using System;

namespace Design_Patterns.Structural.Bridge.StructrualCode
{
	/// <summary>
	/// The 'ConcreteImplementorB' class
	/// </summary>
	public class ConcreteImplementorB : Implementor
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteImplementorB Operation");
		}
	}
}
