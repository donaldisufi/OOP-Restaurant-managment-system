using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Tables
{
	public static class TableStore
	{
		public static List<Table> AllTabels { get; private set; } = new List<Table>();

		public static void CreateNewTable(Table newTable)
		{
			AllTabels.Add(newTable);
		}

		public static void ChangeAvailablityTable(int id, bool value)
		{
			foreach (var item in AllTabels)
			{
				if (item.TableNumber == id)
				{
					item.IsAvailable = value;
				}
			}
		}
		public static int CountAllTables()
		{
			int i = 0;
		   foreach(var item in AllTabels)
			{
				i++;
			}
			return i;
		}
		public static bool ShouldCreateTable(int id )
		{
			foreach (var item in AllTabels)
			{
				if(id == item.TableNumber)
				{
					return false;
				}
			}
			return true;
		}
	}
}
