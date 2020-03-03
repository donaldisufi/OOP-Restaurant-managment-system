using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Menus
{
	public class Category
	{
		public static List<Category> AllCategories { get; private set; } = new List<Category>();

		public Category(int id, string categoryName,string foodordrink)
		{
			Id = id;

			CategoryName = categoryName;
			FoodOrDrink = foodordrink;
		}

		public int Id { get; set; }
		public string CategoryName { get; set; }
		public string FoodOrDrink { get; set; }
		
		public static void AddNewCategory(Category category)
		{
			AllCategories.Add(category);
		}
		public static bool CanCreateCategory(int id)
		{
			foreach(var item in AllCategories)
			{
				if(item.Id == id)
				{
         	      return false;
				}
			}
			return true;
		}
		public static Category ReturnSpecificCategory(string name)
		{

			foreach (var item in AllCategories)
			{
				if (name == item.CategoryName)
					return item;
			}
			return null;
		}
	}
}
