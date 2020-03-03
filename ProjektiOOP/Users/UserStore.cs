using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Users
{
	public static class UserStore
	{
		public static List<User> AllUsers = new List<User>();

		public static void AddNewUser(User u)
		{
			AllUsers.Add(u);

		}

		public static bool CanCreateUser(string email)
		{
			foreach (var item in AllUsers)
			{
				if(item.Email.Trim() == email.Trim())
				{
					return false;
				}
			}
			return true;
		}

		public static User GetUserByEmail(string email)
		{
			foreach (var item in AllUsers)
			{ 
				if(item.Email.Trim() == email.Trim())
				{
					return item;
				}
			}
			return null;
		}

		public static bool Login(string email ,string passi)
		{
			foreach (var item in AllUsers)
			{
				if(email.Trim() == item.Email.Trim() && passi.Trim() == item.Password.Trim())
				{
					return true;
				}
			}
			return false;
		}
	}
}
