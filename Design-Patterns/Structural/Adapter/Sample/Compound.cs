using System;

namespace Design_Patterns.Structural.Adapter.Sample
{
	public class Compound
	{
		protected float boilingPoint;
		protected float meltingPoint;
		protected double molecularWeight;
		protected string molecularFormula;

		public virtual void Display()
		{
			Console.WriteLine("\nCompound: Unknown ");
		}
	}
}
