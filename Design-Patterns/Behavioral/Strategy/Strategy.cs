using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Strategy
{
    public interface Strategy
    {
        public int doOperation(int num1, int num2);
    }
}
