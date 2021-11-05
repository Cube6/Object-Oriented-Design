
namespace Design_Patterns.Behavioral.Memento.StructuralCode
{
	/// <summary>
	/// The 'Caretaker' class
	/// </summary>
	public class Caretaker
	{
		Memento memento;

		public Memento Memento
		{
			set { memento = value; }
			get { return memento; }
		}
	}
}
