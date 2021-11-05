using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle.GoodSample
{
	public class RoleManager
	{
		public void addRole(User user, int roleId)
		{
			Console.WriteLine(user.Name + " was added in role " + roleId);
		}

		public Role CreateRole()
		{
			Role role = new Role();
			return role;
		}
	}
}
