using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command.StructuralCode
{
	public class Receiver
	{
		public void Action()
		{
			Console.WriteLine("Called Receiver.Action()");
		}
	}
}
