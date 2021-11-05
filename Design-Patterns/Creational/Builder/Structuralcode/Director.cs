using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder.Structuralcode
{
	 public class Director
	{
		public void Construct(IBuilder builder)
		{
			builder.SetEngine();
			builder.SetSeats();
			builder.SetGPS();
		}

	}
}
