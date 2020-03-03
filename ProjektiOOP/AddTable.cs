using ProjektiOOP.Tables;
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
	public partial class AddTable : Form
	{
		public AddTable()
		{
			InitializeComponent();
		}
		public bool isValidNumber(string str)
		{
			try
			{
				int.Parse(str);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}
		private void btnAddTable_Click(object sender, EventArgs e)
		{

			if (txtAddTableCapacity.Text.Length >= 1 && txtAddTableNumber.Text.Length >= 1)
			{

				string status = rdAddTableActive.Checked ? "Active" : "Passive";
				if (isValidNumber(txtAddTableNumber.Text) && isValidNumber(txtAddTableCapacity.Text))
				{

					if (TableStore.ShouldCreateTable(int.Parse(txtAddTableNumber.Text)))
					{

						TableStore.CreateNewTable(new Table(int.Parse(txtAddTableNumber.Text), int.Parse(txtAddTableCapacity.Text), status));
						MessageBox.Show("Tavolina u regjistrua me sukses");
						txtAddTableCapacity.Clear();
						txtAddTableNumber.Clear();
					}
					else
					{
						MessageBox.Show("TAvolina me kete Id ekziston");
					}

				}
				else
				{
					MessageBox.Show("Ju lutem shkruani fushtat ne formatin e duhur : Numer");
				}
			}
			else
			{
				MessageBox.Show("ju lutem mbushni te gjitha fushat");

			}
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.ShowDialog();
			this.Close();
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			MenuForm formMenu = new MenuForm();
			this.Hide();
			formMenu.ShowDialog();
			this.Close();
		}

		private void btnNavAddMenu_Click(object sender, EventArgs e)
		{
			AddMenu formMenu = new AddMenu();
			this.Hide();
			formMenu.ShowDialog();
			this.Close();
		}

		private void btnOrders_Click(object sender, EventArgs e)
		{
			// Show Order Form
			this.Hide();
			OrderForm obj = new OrderForm();
			obj.ShowDialog();
			this.Close();
		}

		private void btnNavAddTable_Click(object sender, EventArgs e)
		{

		}
	}
}
