using System;

namespace Design_Patterns.Structural.Adapter.Sample
{
	public class RichCompound : Compound
	{
		private string chemical;
		private ChemicalDatabank bank;
		// Constructor
		public RichCompound(string chemical)
		{
			this.chemical = chemical;
		}
		public override void Display()
		{
			// The Adaptee
			bank = new ChemicalDatabank();
			boilingPoint = bank.GetCriticalPoint(chemical, "B");
			meltingPoint = bank.GetCriticalPoint(chemical, "M");
			molecularWeight = bank.GetMolecularWeight(chemical);
			molecularFormula = bank.GetMolecularStructure(chemical);
			Console.WriteLine("\nCompound: {0}", chemical);
			Console.WriteLine("\tFormula: {0}", molecularFormula);
			Console.WriteLine("\tWeight : {0}", molecularWeight);
			Console.WriteLine("\tMelting Pt: {0}", meltingPoint);
			Console.WriteLine("\tBoiling Pt: {0}", boilingPoint);
		}
	}
}
