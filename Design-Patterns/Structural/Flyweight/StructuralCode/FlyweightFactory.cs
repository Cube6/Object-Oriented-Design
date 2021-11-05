using System.Collections.Generic;

namespace Design_Patterns.Structural.Flyweight.StructuralCode
{
	/// <summary>
	/// The 'FlyweightFactory' class
	/// </summary>
	public class FlyweightFactory
	{
		private Dictionary<string, Flyweight> flyweights { get; set; } = new Dictionary<string, Flyweight>();
		// Constructor
		public FlyweightFactory()
		{
			flyweights.Add("X", new ConcreteFlyweight());
			flyweights.Add("Y", new ConcreteFlyweight());
			flyweights.Add("Z", new ConcreteFlyweight());
		}
		public Flyweight GetFlyweight(string key)
		{
			return ((Flyweight)flyweights[key]);
		}
	}
}
