/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>

using System;

namespace Design_Patterns.Structural.Bridge.StructrualCode
{
	/// <summary>
	/// The 'ConcreteImplementorA' class
	/// </summary>
	public class ConcreteImplementorA : Implementor
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteImplementorA Operation");
		}
	}
}
