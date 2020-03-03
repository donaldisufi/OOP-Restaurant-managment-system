using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Menus
{
	public class Food : MenuItem
	{
		public override string FoodOrDrink { get; set; }
		public Food(string name, Category kategori, string description, decimal price, string recipe, string type) :base( name, kategori, description, price , recipe, type)
		{
			FoodOrDrink = "Food";
		}

		public Food(string itemName, Category myCategory, string description, decimal price, string recipe) : base(itemName, myCategory, description, price, recipe)
		{
			FoodOrDrink = "Food";

		}
	}

}
