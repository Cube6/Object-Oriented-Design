using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle.GoodSample
{
	public class User
	{
		private string name;
		private string password;

		public List<Role> roles;

		public Org org;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

	}
}
