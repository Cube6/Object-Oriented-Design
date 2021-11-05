using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.ChainOfResponsibility.Sample
{
	class VacationCOR
	{
        Handler h1 = new Moniter();
        Handler h2 = new Instructor();
        Handler h3 = new DepartmentChairman();

        //........

        public VacationCOR()
        {
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
