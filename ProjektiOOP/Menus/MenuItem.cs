using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Menus
{
	public class MenuItem
	{
		public virtual string FoodOrDrink { get; set; }
		public MenuItem( string itemName, Category myCategory, string description, decimal price, string recipe )
		{
			index++;
			Id = index;
			Description = description;
			ItemName = itemName;
			MyCategory = myCategory;
			Price = price;
			IsActive = true;
			Recipe = recipe;
		}

		public MenuItem(string itemName, Category myCategory, string description, decimal price, string recipe,string type)
		{
			index++;
			Id = index;
			Description = description;
			ItemName = itemName;
			MyCategory = myCategory;
			Price = price;
			IsActive = true;
			Recipe = recipe;
			Type = type;
		}

		static int index = 0;
		public int Id { get; set; }
		public string Type { get; set; }
		public string ItemName { get; set; }
		public string Recipe { get; set; }	
		public Category MyCategory { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public bool IsActive { get; set; }

	}
}
