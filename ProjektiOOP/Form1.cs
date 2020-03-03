using ProjektiOOP.Employees;
using ProjektiOOP.Menus;
using ProjektiOOP.Orders;
using ProjektiOOP.Tables;
using ProjektiOOP.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjektiOOP.Orders.Order;
using MenuItem = ProjektiOOP.Menus.MenuItem;

namespace ProjektiOOP
{
	public partial class Form1 : Form
	{

		bool visible = false;
		string DropdownChecked;
		public Form1()
		{
			InitializeComponent();
			ShowNewItemsInDropdown();
			
			lblAllTables.Text = TableStore.CountAllTables().ToString();
			lblAllMenus.Text = MenuStore.CountAllMenus().ToString();
			lblRezervimet.Text = ApointmentStore.AllApointment.Count.ToString();
			ShowAllTablesInMainPanel();


		}


		public void ShowThemostSoldProduct()
		{
			OrderDetail orderDetail = OrdersCalculator.FindThemostSoldProduct(OrderStore.AllOrders);
			MessageBox.Show($"Produkti me i shitur eshte :{orderDetail.Item.ItemName} \n Me sasi : {orderDetail.Quantity.ToString()}");
		}
		private void btnHome_Click(object sender, EventArgs e)
		{
			

			MainPanel.Controls.Clear();
			ShowAllTablesInMainPanel();
			Application.DoEvents();

		}
		private void btn_Click(object sender, EventArgs e)
		{
			lblAllTables.ResetText();
			lblAllMenus.ResetText();
			//MainPanel.Visible = false;
			//panelAddMenu.Visible = true;
			//panelAddTable.Visible = false;
			//cmbKateoriMenu.Visible = true;
			//btnShtoKategori.Visible = true;
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
		public bool isValidDecimal(string d)
		{
			try
			{
				decimal.Parse(d);
				return true;

			}
			catch (Exception)
			{

			  return false;
			}
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

		private void btnAddMenu_Click(object sender, EventArgs e)
		{
			//if (isValidDecimal(txtMenuPrice.Text)) {
			//	MenuStore.CreateNewMenuItem(new Menus.MenuItem(1, txtMenuName.Text, new Category() { CategoryName = txtMenuCategory.Text, Id = 100 }, txtMenuDescription.Text, decimal.Parse(txtMenuPrice.Text), true));
	  //      }
			//string str = "";
			//foreach(var item in MenuStore.AllMenuItems)
			//{
			//	str += $"{item.ItemName} , {item.MyCategory.CategoryName} , \n";
			//}
			//MessageBox.Show($"U regjsitrua me sukses Menuja .\n {str}");
		}




		private void label2_Click(object sender, EventArgs e)
		{

		}
		private void btnAddTable_Click(object sender, EventArgs e)
		{
			//if (isValidNumber(txtTableSeats.Text) && isValidNumber(txtTableNumber.Text))
			//{
			//	TableStore.CreateNewTable(new Table() { IsAvailable = true, SeatsCapacity = int.Parse(txtTableSeats.Text), TableNumber = int.Parse(txtTableNumber.Text) });
			//}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			

		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello");
		}


		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}
		
		/// Panel i Add Menu
		/// -----------------------------------------------------------------------
	    public string GetAllMenus()
		{
			string str = "";
			foreach(var item in MenuStore.AllMenuItems)
			{
				str += $"{item.ItemName} {item.Type} , {item.Price} , {item.MyCategory.CategoryName} \n";
			}
			return str;
		}
		private void btnShowRadioButton_Click(object sender, EventArgs e)
		{
			visible = !visible;
		
		}
	
		private void btnAddMenuAdd_Click(object sender, EventArgs e)
		{
			//if ( txtAddMenuDecription.Text.Length >= 1  && txtAddMenuPrice.Text.Length >= 1 && txtAddMenuRecipe.Text.Length >= 1 && txtAddMenuItem.Text.Length >= 1 && cmbKateoriMenu.Text.Length>=1)
			//{
			//	if (isValidDecimal(txtAddMenuPrice.Text))
			//	{
					
			//		decimal Price = decimal.Parse(txtAddMenuPrice.Text);
			//		string Name = txtAddMenuItem.Text;
			//		string Description = txtAddMenuDecription.Text;
			//		string Recipe = txtAddMenuRecipe.Text;
			//		Category kategoria = Category.ReturnSpecificCategory(DropdownChecked);
			//		if (rdMesme.Visible)
			//		{
			//			MenuItem obj = new Food(Name, kategoria, Description, Price, Recipe, WhichRadioButtonIsChecked());
			//			MenuStore.CreateNewMenuItem(obj);
			//		}
			//		else
			//		{
			//			MenuItem obj = new Food(Name, kategoria, Description, Price, Recipe);
			//			MenuStore.CreateNewMenuItem(obj);
			//		}
			//		MessageBox.Show(GetAllMenus());
			//		lblAllMenus.Text = MenuStore.CountAllMenus().ToString();

			//	}
			//	else
			//	{
			//		MessageBox.Show("Ju lutem shkrauni cmimin dhe id e kateogrise numer!");
			//	}
			//}
			//else
			//{
			//	MessageBox.Show("Ju lutem mbushni te gjitha Fushat !!");
			//}
		}
		//------------------------------------------------
		// Add Table Panel 

		public void ShowAllTablesInMainPanel()
		{
			MainPanel.Controls.Clear();

			int x = 5;
			int y = 5;
			string btn = "b";
			int c = 1;
			foreach (var item in TableStore.AllTabels)
			{
				Button button = new Button();
				button.Location = new Point(x, y);
				button.Text = item.TableNumber.ToString();
				button.Width = 150;
				button.Height = 90;
				button.Name = btn;
				Font font = new Font("Arial", 20, FontStyle.Bold);
				button.Font = font;
				btn += "c";
				x += 170;
				if (c % 5== 0)
				{
					y += 100;
					x = 5;
				}
				button.BackColor = Color.Blue;
				MainPanel.Controls.Add(button);
				c++;
			}
		}
		private void btnAddTable_Click_1(object sender, EventArgs e)
		{
			if(txtAddTableCapacity.Text.Length >=1 && txtAddTableNumber.Text.Length >= 1)
			{
				string status = rdAddTableActive.Checked ? "Active" : "Passive";
				if(isValidNumber(txtAddTableNumber.Text) && isValidNumber(txtAddTableCapacity.Text))
				{
					TableStore.CreateNewTable(new Table(int.Parse(txtAddTableNumber.Text), int.Parse(txtAddTableCapacity.Text), status));
					MessageBox.Show("Tavolina u regjistrua me sukses");
					txtAddTableCapacity.Clear();
					txtAddTableNumber.Clear();
					lblAllTables.Text = TableStore.CountAllTables().ToString();
				}
				else
				{
					MessageBox.Show("Ju lutem shkruani fushtat ne formatin e duhur : Numer");
				}
				
			}else
			{
				MessageBox.Show("ju lutem mbushni te gjitha fushat");
			}
		}

	
		private void panel6_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			lblAllTables.ResetText();
			lblAllMenus.ResetText();
			this.Hide();
			MenuForm formMenu = new MenuForm();
			formMenu.ShowDialog();
			this.Close();

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}
		//------------------------------------------------------------------------------------
		// Kategory Side : ------------------------------------------------------------------
		private void cmbKateoriMenu_SelectedIndexChanged(object sender, EventArgs e)
		{
			//DropdownChecked = cmbKateoriMenu.Text;
			
		}
		public void ShowNewItemsInDropdown()
		{
		//	var b = "";
		//	foreach (var item in Category.AllCategories)
		//	{
		//		b = item.CategoryName;
		//		cmbKateoriMenu.Items.Add(b);
		//	}
		}

		private void btnShtoKategori_Click(object sender, EventArgs e)
		{
		//	if(txtAddCategoryId.Text.Length >=1 && txtAddCategoryName.Text.Length >= 1 )
		//	{
		//		if (isValidNumber(txtAddCategoryId.Text))
		//		{
		//			if (!Category.IsIdUnique(int.Parse(txtAddCategoryId.Text)))
		//			{
		//				MessageBox.Show("Tashme Ekziston nje kategori me kete Id");
		//			}else
		//			{
					
		//					Category.AddNewCategory(new Category(int.Parse(txtAddCategoryId.Text), txtAddCategoryName.Text,));
		//				    cmbKateoriMenu.Items.Clear();
		//					ShowNewItemsInDropdown();
		//					txtAddCategoryId.Text = string.Empty;
		//					txtAddCategoryName.Text = string.Empty;
		//			}
		//		}
		//	   else
		//	     MessageBox.Show("Shkruani Id numer Valid!");


		//	}
		//	else
		//	{
		//		MessageBox.Show("Ju lutem mbushni te gjitha fushat !");
		//	}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void btnOrders_Click(object sender, EventArgs e)
		{
			this.Hide();
			OrderForm obj = new OrderForm();
			obj.ShowDialog();
			this.Close();
		}

		private void txtAddTableNumber_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtAddTableCapacity_TextChanged(object sender, EventArgs e)
		{

		}

		private void rdAddTablePassive_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void MainPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnRezervo_Click(object sender, EventArgs e)
		{
			
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			RezervationForm res = new RezervationForm();
			this.Hide();
			res.ShowDialog();
			this.Close();
		}

		private void button2_Click_2(object sender, EventArgs e)
		{

			Login res = new Login();
			TempEmployee.currentEmployee = null;
			this.Hide();
			res.ShowDialog();
			this.Close();
		}
	}
}
