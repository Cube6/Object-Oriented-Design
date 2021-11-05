using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.ChainOfResponsibility.Sample
{
	public abstract class Handler
	{
		public Handler nextHandler;
		public void SetSuccessor(Handler successorHandler)
		{
			nextHandler = successorHandler;
		}

		public abstract void HandleRequest(int request);
	}
}
