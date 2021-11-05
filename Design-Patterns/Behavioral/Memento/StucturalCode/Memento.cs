
namespace Design_Patterns.Behavioral.Memento.StructuralCode
{
	/// <summary>
	/// The 'Memento' class
	/// </summary>
	public class Memento
	{
		string state;
		// Constructor
		public Memento(string state)
		{
			this.state = state;
		}
		public string State
		{
			get { return state; }
		}
	}
}
