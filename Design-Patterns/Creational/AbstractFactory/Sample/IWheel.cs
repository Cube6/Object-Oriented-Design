using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactory.Sample
{
	public interface IWheel
	{
		Wheel CreateWheel();
	}
}
