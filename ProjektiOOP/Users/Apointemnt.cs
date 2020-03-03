using ProjektiOOP.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Users
{
	public class Apointemnt
	{
		static int count = 1;
		public Apointemnt(Table table, DateTime data,User use,int numberofPersons)
		{
			this.table = table;
			Data = data;
			user = use;
			PersonsNumber = numberofPersons;
			ID = count++;

		}

		public Table table{ get; set; }
		public DateTime Data { get; set; }
		public User user { get; set; }
		public int PersonsNumber { get; set; }
		public int ID { get; set; }

	}
}
