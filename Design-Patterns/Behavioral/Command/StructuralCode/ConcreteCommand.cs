using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command.StructuralCode
{
	public class ConcreteCommand : Command
	{
		private Receiver _receiver;
		public ConcreteCommand(Receiver receiver)
		{
			_receiver = receiver;
		}
		public override void Execute()
		{
			_receiver.Action();
		}
	}
}
