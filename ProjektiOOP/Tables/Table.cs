using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Tables
{
	public class Table
	{
		public Table(int tablenumber, int capacity,string status)
		{
			TableNumber = tablenumber;
			Capacity = capacity;
			IsAvailable = true;
			Status = status;
		}

		public int TableNumber { get; set; }
		public int Capacity { get; set; }
		public bool IsAvailable { get; set; }
		public string Status { get; set; }
	


		public void ChangeAvailablityTable(bool value)
		{
			IsAvailable = value;
		}

		
	}
}
