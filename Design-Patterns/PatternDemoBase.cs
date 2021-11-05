using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
	public abstract class PatternDemoBase
	{
		public void Run()
		{
			Console.WriteLine($"-----------{PatternName}-----------");

			RunImpl();

			Console.WriteLine($"----------------------------------");
			Console.WriteLine(Environment.NewLine);
		}

		protected abstract void RunImpl();
		public abstract string PatternName { get; }
	}
}
