/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>


namespace Design_Patterns.Structural.Bridge.StructrualCode
{
	/// <summary>
	/// The 'RefinedAbstraction' class
	/// </summary>
	public class RefinedAbstraction : Abstraction
	{
		public override void Operation()
		{
			implementor.Operation();
		}
	}
}
