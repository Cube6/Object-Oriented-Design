using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle.GoodSample
{
	public static class UserGoodSample
	{
		public static void Run()
		{
			Console.WriteLine("------Good SRP Sample------");
			UserManager userManager = new UserManager();
			OrgManager orgManager = new OrgManager();
			RoleManager roleManager = new RoleManager();
			User user = userManager.CreateUser();
			user.roles.Add(roleManager.CreateRole());
			user.org = orgManager.CreateOrg();
		}
	}
}
