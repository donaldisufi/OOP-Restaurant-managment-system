using ProjektiOOP.Components;
using ProjektiOOP.Employees;
using ProjektiOOP.Menus;
using ProjektiOOP.Orders;
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
	public partial class OrderForm : Form
	{

		public Order orderSelected;
		public Menus.MenuItem menuSelected;
		public Table tableSelected;

		public OrderForm()
		{
			InitializeComponent();
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
			this.Hide();
			MenuForm formMenu = new MenuForm();
			formMenu.ShowDialog();
			this.Close();

		}

		private void btnNavAddMenu_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddMenu formMenu = new AddMenu();
			formMenu.ShowDialog();
			this.Close();

		}

		private void btnNavAddTable_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddTable obj = new AddTable();
			obj.ShowDialog();
			this.Close();
		}

		private void OrderForm_Load(object sender, EventArgs e)
		{
			LoadOrders();
			ShowMenusDropDown();
			ShowOrdersDropDown();
			ShowTablesDropDown();
		}

		public  void LoadOrders()
		{
			mainScrollView.Controls.Clear();
			OrderContainer obj; //347 hieght
			int x = 5;
			int y = 1;
			foreach (var item in OrderStore.GetUnCompletedOrders())
			{
				obj = new OrderContainer(item);
				obj.Location = new Point(x, y);
				x += 349;
				mainScrollView.Controls.Add(obj);
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadOrders();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnKrijo_Click(object sender, EventArgs e)
		{
			if (cmbTables.Text.Length >= 1)
			{

				try
				{
					OrderStore.CreateNewOrder(new Order(tableSelected, DateTime.Now,TempEmployee.currentEmployee));
					ShowOrdersDropDown();
					LoadOrders();
				}
				catch (Exception)
				{
					MessageBox.Show("Nje gabim ndodhi");
				}
			}
			
		}
		public void ShowTablesDropDown()
		{
			cmbTables.Items.Clear();

			string b = "";

			foreach (var item in TableStore.AllTabels)
			{
				b = item.TableNumber.ToString();
				cmbTables.Items.Add(b);

			}
		}

		public void ShowOrdersDropDown()
		{
			cmbOrders.Items.Clear();
			string b = "";
			foreach (var item in OrderStore.GetUnCompletedOrders())
			{
				b = item.OrderId.ToString();
				cmbOrders.Items.Add(b);

			}

		}

		public void ShowMenusDropDown()
		{
			cmbMenus.Items.Clear();
			string b = "";
			foreach (var item in MenuStore.AllMenuItems)
			{
				b = item.ItemName.ToString();
				cmbMenus.Items.Add(b);

			}

		}

		private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach(var item in TableStore.AllTabels)
			{
				if(item.TableNumber.ToString() == cmbTables.Text)
				{
					tableSelected = item;
				}
			}
		}

		private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (var item in OrderStore.GetUnCompletedOrders())
			{
				if(item.OrderId.ToString() == cmbOrders.Text)
				{
					orderSelected = item;
				} 
			}
		}

		private void cmbMenus_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (var item in MenuStore.AllMenuItems)
			{
				if(item.ItemName == cmbMenus.Text)
				{
					menuSelected = item;
				}
			}
		}

		public bool isANumber(string str)
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

		private void btnShtoProdukte_Click(object sender, EventArgs e)
		{
			if (isANumber(txtSasia.Text))
			{
				if (int.Parse(txtSasia.Text) >= 1)
				{
					orderSelected.AddMenuItemsinOrder(menuSelected, int.Parse(txtSasia.Text));
					LoadOrders();
				}else
				{
					MessageBox.Show("Sasia duhet te jet me shum se 0");
				}

			} else
			{
				MessageBox.Show("Sasia duhet te jet numer");
			}

		}

		private void mainScrollView_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
