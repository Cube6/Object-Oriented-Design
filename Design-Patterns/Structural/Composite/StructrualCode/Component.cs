namespace Design_Patterns.Structural.Composite.StructrualCode
{
	/// <summary>
	/// The 'Component' abstract class
	/// </summary>
	public abstract class Component
	{
		protected string name;
		// Constructor
		public Component(string name)
		{
			this.name = name;
		}
		public abstract void Add(Component c);
		public abstract void Remove(Component c);
		public abstract void Display(int depth);
	}
}
