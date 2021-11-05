using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle.GoodSample
{
	public class UserManager
	{
		public User CreateUser()
		{
			User user = new User();
			user.Name = "test";
			user.Password = "testpassword";
			return user;
		}
	}
}
