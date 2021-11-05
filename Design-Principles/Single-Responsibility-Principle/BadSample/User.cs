using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle.BadSample
{
	public class User
	{
		private string name;
		private string password;

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

		public void CreateUser()
		{
			name = "test";
			password = "1234";
			AddOrg(1);
			AddRole(1);
		}


		public void AddRole(int roleId)
		{
			Console.WriteLine(name +"added in role "+roleId);
		}
		public void AddOrg(int orgId)
		{
			Console.WriteLine(name + "added in org " + orgId);
		}
	}
}
