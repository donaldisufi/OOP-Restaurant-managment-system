using ProjektiOOP.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Users
{
	public class User
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
        
		Table ReservedTable;

		public User(string email, string password, string name)
		{
			Email = email;
			Password = password;
			Name = name;
		}

		public void ReserveTable (Table obj)
		{
			ReservedTable = obj;
		}
	}
}
