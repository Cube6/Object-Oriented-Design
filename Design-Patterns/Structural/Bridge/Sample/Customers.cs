/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>

using System;

namespace Design_Patterns.Structural.Bridge.Sample
{
	/// <summary>
	/// The 'RefinedAbstraction' class
	/// </summary>
	public class Customers : CustomersBase
	{
		public override void ShowAll()
		{
			// Add separator lines
			Console.WriteLine();
			Console.WriteLine("------------------------");
			base.ShowAll();
			Console.WriteLine("------------------------");
		}
	}
}
