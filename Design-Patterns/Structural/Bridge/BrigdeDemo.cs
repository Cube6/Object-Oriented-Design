/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>

using Design_Patterns.Structural.Bridge.Sample;
using System;

namespace Design_Patterns.Structural.Bridge
{
	public class BrigdeDemo : PatternDemoBase
	{
		public override string PatternName => "Brigde Pattern";

		protected override void RunImpl()
		{
			// Create RefinedAbstraction
			var customers = new Customers();
			// Set ConcreteImplementor
			customers.Data = new CustomersData("Chicago");
			// Exercise the bridge
			customers.Show();
			customers.Next();
			customers.Show();
			customers.Next();
			customers.Show();
			customers.Add("Henry Velasquez");
			customers.ShowAll();
			// Wait for user
			Console.ReadKey();
		}
	}
}
