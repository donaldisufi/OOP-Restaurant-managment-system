using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektiOOP.Menus;

namespace ProjektiOOP.Components
{
	public partial class MenuRow : UserControl
	{
		Menus.MenuItem Item;
		public MenuRow(Food obj)
		{
			InitializeComponent();
			txtEmri.Text = obj.ItemName;
			txtKategoria.Text = obj.MyCategory.CategoryName;
			txtCmimi.Text = obj.Price.ToString("0.00") + " €";
			Item = obj;

		}
		public MenuRow()
		{
			InitializeComponent();

		}

		public MenuRow(Drink obj)
		{
			InitializeComponent();
			txtEmri.Text = obj.ItemName;
			txtKategoria.Text = obj.MyCategory.CategoryName;
			txtCmimi.Text = obj.Price.ToString("0.00") + " €";
			Item= obj;
		}

		private void MenuRow_Load(object sender, EventArgs e)
		{

		}

		private void txtLloji_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
			MenuStore.DeleteMenuItem(Item);
			MessageBox.Show("Produkti u fshi me sukses , kliko refresh per ti rifreskuar te dhenat");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Produkti nuk u fshi me sukses , nje gabim ka ndodhur");
			}
		}
	}
}
