using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Menus
{
	public static class MenuStore
	{
		public static List<MenuItem> AllMenuItems { get; private set; } = new List<MenuItem>();
		public static void CreateNewMenuItem(MenuItem Item)

		{
			AllMenuItems.Add(Item);

		}
		public static List<MenuItem> ReturnMenuItemsWithSpecificCategory(int IdCategory)
		{
			List<MenuItem> SpecificCategory = new List<MenuItem>();
			foreach (var item in AllMenuItems)
			{
				if (item.MyCategory.Id == IdCategory)
				{
					SpecificCategory.Add(item);
				}
			}
			return SpecificCategory;
		}
		public static int CountAllMenus()
		{
			int i = 0;
			foreach (var item in AllMenuItems)
			{
				i++;
			}
			return i;
		}

		public static void DeleteMenuItem(MenuItem obj)
		{
					AllMenuItems.Remove(obj);
				
		}
	
	}
}
