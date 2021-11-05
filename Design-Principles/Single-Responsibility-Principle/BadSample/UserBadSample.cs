using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle.BadSample
{
	public static class UserBadSample
	{
		public static void Run()
		{
			Console.WriteLine("------Bad SRP Sample------");
			User user = new User();
			user.CreateUser();
		}
	}
}
