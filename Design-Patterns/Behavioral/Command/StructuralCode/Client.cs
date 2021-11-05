using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command.StructuralCode
{
	public class Client
	{
		public void Run()
		{
			Receiver receiver = new Receiver();
			var concreteCommand = new ConcreteCommand(receiver);
			Invoker invoker = new Invoker();
			invoker.command = concreteCommand;
			invoker.ExecuteCommand();
		}
	}
}
