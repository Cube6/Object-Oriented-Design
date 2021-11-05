using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.ChainOfResponsibility.Sample
{
	public class Moniter : Handler
	{
		public override void HandleRequest(int request)
		{
            if (request >= 0 && request <= 1)
            {
                Console.WriteLine("{0} handled request {1}",
                    this.GetType().Name, request);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
	}
}
