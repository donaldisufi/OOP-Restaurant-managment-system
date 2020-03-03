using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Menus
{
	public class Drink :MenuItem
	{
		public override string FoodOrDrink { get; set; }
		public Drink(string name, Category kategori, string description, decimal price, string recipe, string type) : base(name, kategori, description, price, recipe, type)
		{
			FoodOrDrink = "Drink";
		}

		public Drink(string itemName, Category myCategory, string description, decimal price, string recipe) : base(itemName, myCategory, description, price, recipe)
		{
			FoodOrDrink = "Drink";

		}
	}
}
