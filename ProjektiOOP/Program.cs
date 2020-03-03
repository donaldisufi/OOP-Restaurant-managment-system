using ProjektiOOP.Employees;
using ProjektiOOP.Menus;
using ProjektiOOP.Orders;
using ProjektiOOP.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuItem = ProjektiOOP.Menus.MenuItem;

namespace ProjektiOOP
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Category obj = new Category(1, "Skare", "Food");
			Category pije = new Category(10, "Pije", "Drink");
			Category.AddNewCategory(obj);
			Category.AddNewCategory(pije);

			Food ob = new Food("hell", obj, "adssads", 3, "sadsa", "asdsad");
			Drink dr = new Drink("CocaCola", obj, "sdadsa", 2, "sadasdsa");
			MenuStore.CreateNewMenuItem(new Food("Mish i Bardhe",obj,"Perskrimi i mishit",(decimal)2.50,"Receta"));
			MenuStore.CreateNewMenuItem(new Food("Qebapa 5she", obj, "Perskrimi i mishit", (decimal)1.50, "Receta"));
			MenuStore.CreateNewMenuItem(new Food("Pleskavice ne pjate", obj, "Perskrimi i mishit", (decimal)3.50, "Receta"));
			MenuStore.CreateNewMenuItem(dr);
			MenuStore.CreateNewMenuItem(new Drink("Kafe Makiato",pije,"dadsadsa",1,"dsad"));
			TableStore.CreateNewTable(new Table(1, 4, "Altiv"));
			TableStore.CreateNewTable(new Table(2, 4, "Altiv"));
			TableStore.CreateNewTable(new Table(3, 4, "Altiv"));

			TableStore.CreateNewTable(new Table(4,4,"Altiv"));
			Category.AddNewCategory(new Category(20, "Supa", "Food"));
			Category.AddNewCategory(new Category(30, "Pizza", "Food"));


			Category.AddNewCategory(new Category(40, "Caj", "Drink"));
			Category.AddNewCategory(new Category(50, "Kafe", "Drink"));


		    EmployesStore.AddNewEmployee(new Employee("Donald", "Isufi", "admin", "123456","Zenel Bajraktari"));
			EmployesStore.AddNewEmployee(new Employee("Altin", "Gashi", "admin2", "123456","Ismet munishi"));

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		
		}
	}
}
