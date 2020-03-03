using PersonLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Employees
{
	public class Employee : Person
	{
		static int count = 0;
		public string Email { get; set; }
		public string Password { get; set; }
		public int ID { get; set; }

		public Employee(string name, string lastName, string email,string pass,string adres) :base(name,lastName,adres)
		{
			Email = email;
			Password = pass;
			ID = count++;
		}
	
	}
}
