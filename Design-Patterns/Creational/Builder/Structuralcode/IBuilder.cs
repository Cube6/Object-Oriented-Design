using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Structuralcode
{ 
	public interface IBuilder
	{

		void SetSeats();
		void SetEngine();
		void SetGPS();

		Product GetResult();
	}
}
