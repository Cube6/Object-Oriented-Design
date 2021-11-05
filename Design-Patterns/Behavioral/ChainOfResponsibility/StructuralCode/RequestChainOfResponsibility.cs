using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.ChainOfResponsibility.StructuralCode
{
	public class RequestChainOfResponsibility
    {
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();
        Handler h3 = new ConcreteHandler3();

        //........

        public RequestChainOfResponsibility() {
            // Setup Chain of Responsibility
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);
        }

        public void handleRequest(int request)
		{
            h1.HandleRequest(request);
        }
    }
}
