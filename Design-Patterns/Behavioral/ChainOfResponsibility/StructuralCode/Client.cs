using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.ChainOfResponsibility.StructuralCode
{
	public class Client
    {
        public void run()
        {
            RequestChainOfResponsibility requestChainOfResponsibility = new RequestChainOfResponsibility();
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };
            foreach (int request in requests)
            {
                requestChainOfResponsibility.handleRequest(request);
            }
        }
    }
}
