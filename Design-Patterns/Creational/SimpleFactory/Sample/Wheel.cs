using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.SimpleFactory.Sample
{
	public abstract class Wheel
	{
		public string Name { get;set;}
		public Wheel()
		{

		}

		public virtual void Create()
		{
			Console.WriteLine("Wheel Create");
		}
	}
}
