using ProjektiOOP.Components;
using ProjektiOOP.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektiOOP
{
	public partial class MenuForm: Form
	{
		MenuRow ne;

		public MenuForm()
		{
			InitializeComponent();
			panFood.Controls.Clear();
			panDrink.Controls.Clear();
			int y = 55;
			int YF = 55;
			foreach (var item in MenuStore.AllMenuItems)
			{
				if (item.FoodOrDrink == "Food")
				{
					ne = new MenuRow((Food)item);
					ne.Location = new Point(18, y);
					panFood.Controls.Add(ne);
					y += 45;

				}
				else
				{
					ne = new MenuRow((Drink)item);
					ne.Location = new Point(18, YF);
					panDrink.Controls.Add(ne);
					YF += 45;
				}

			}
		}

		private void Menu_Load(object sender, EventArgs e)
		{
	
		}

		private void btnHome_Click(object sender, EventArgs e)
		{

			foreach(var item in panFood.Controls)
			{
				panFood.Controls.Remove((Control)item);
			}
			foreach (var item in panDrink.Controls)
			{
				panFood.Controls.Remove((Control)item);
			}
			panFood.Controls.Clear();
			panDrink.Controls.Clear();
			ne = null;
			Form1 form1 = new Form1();
			this.Hide();
			form1.ShowDialog();
			this.Close();
		}

		private void panFood_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			Application.DoEvents();
		}

		private void btnNavAddMenu_Click(object sender, EventArgs e)
		{
			panFood.Controls.Clear();
			panDrink.Controls.Clear();

			AddMenu formMenu = new AddMenu();
			this.Hide();
			formMenu.ShowDialog();
			this.Close();
		}

		private void btnNavAddTable_Click(object sender, EventArgs e)
		{
			panFood.Controls.Clear();
			panDrink.Controls.Clear();
			AddTable obj = new AddTable();
			this.Hide();
			obj.ShowDialog();
			this.Close();
		}

		private void panFood_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			panFood.Controls.Clear();
			panDrink.Controls.Clear();
			int y = 55;
			int YF = 55;
			foreach (var item in MenuStore.AllMenuItems)
			{
				if (item.FoodOrDrink == "Food")
				{
					ne = new MenuRow((Food)item);
					ne.Location = new Point(18, y);
					panFood.Controls.Add(ne);
					y += 45;

				}
				else
				{
					ne = new MenuRow((Drink)item);
					ne.Location = new Point(18, YF);
					panDrink.Controls.Add(ne);
					YF += 45;
				}

			}

		}

		private void btnOrders_Click(object sender, EventArgs e)
		{
			// Show Order Form 
			panFood.Controls.Clear();
			panDrink.Controls.Clear();
			this.Hide();
			OrderForm obj = new OrderForm();
			obj.ShowDialog();
			this.Close();

		}

		private void panDrink_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
