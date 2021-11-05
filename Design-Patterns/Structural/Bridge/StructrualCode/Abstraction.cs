/// <copyright>
/// Copyright Unisys 2021.  All rights reserved.
/// </copyright>


namespace Design_Patterns.Structural.Bridge.StructrualCode
{
	/// <summary>
	/// The 'Abstraction' class
	/// </summary>
	public class Abstraction
	{
		protected Implementor implementor;
		public Implementor Implementor
		{
			set { implementor = value; }
		}
		public virtual void Operation()
		{
			implementor.Operation();
		}
	}
}
