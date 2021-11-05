using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Command.Sample
{
	public abstract class Command
	{
		public Guid Id { get; set; }

		public DateTime CreateOn { get; set; }

		public CommandState Status { get; set; }

		public abstract void Execute();

		public abstract void Undo();
	}
}
