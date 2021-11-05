using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command.StructuralCode
{
	public class Invoker
	{
		public Command command { get; set; }

		public void ExecuteCommand()
		{
			command.Execute();
		}
	}
}
