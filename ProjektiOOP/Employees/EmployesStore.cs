using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Employees
{
	public static class EmployesStore
	{
		public static List<Employee> AllEmployees = new List<Employee>();

		public static bool AddNewEmployee(Employee obj)
		{

			string email = obj.Email;
			foreach (var item in AllEmployees)
			{
				if(item.Email == email)
				{
					return false;
				}
			}

			AllEmployees.Add(obj);
			return true;

		}

		public static bool Authenticate( string email, string password)
		{

			foreach (var item in AllEmployees)
			{
				if(item.Email.Trim() == email.Trim() && item.Password.Trim() == password.Trim())
				{
					return true;
				}
			}
			return false;
		}

		public static Employee GetEmployeeByEmail(string email)
		{
			foreach(var item in AllEmployees)
			{
				if(item.Email.Trim() == email.Trim())
				{
					return item;
				}

			}
			return null;
		}



	}
}
