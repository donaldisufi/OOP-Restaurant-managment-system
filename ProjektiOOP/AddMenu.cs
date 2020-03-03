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
using MenuItem = ProjektiOOP.Menus.MenuItem;

namespace ProjektiOOP
{
	public partial class AddMenu : Form
	{
		bool visible = false;
		string DropdownChecked;
		string CategoryType;

		string TypeSelected;
		Category categorySelected;


		public AddMenu()
		{
			InitializeComponent();

		
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
		public string WhichRadioButtonIsChecked()
		{
			return rdMadhe.Checked ? "Madhe" : rdMesme.Checked ? "Mesme" : "Vogel";
		}
		
		private void btnAddMenuAdd_Click(object sender, EventArgs e)
		{
			if (txtAddMenuDecription.Text.Length >= 1 && txtAddMenuPrice.Text.Length >= 1 && txtAddMenuRecipe.Text.Length >= 1 && txtAddMenuItem.Text.Length >= 1 && cmbKateoriMenu.Text.Length >= 1)
			{
				if (isValidDecimal(txtAddMenuPrice.Text))
				{

					decimal Price = decimal.Parse(txtAddMenuPrice.Text);
					string Name = txtAddMenuItem.Text;
					string Description = txtAddMenuDecription.Text;
					string Recipe = txtAddMenuRecipe.Text;
				

					if (rdMesme.Visible)
					{
						if(TypeSelected == "Food")
						{
							MenuItem obj = new Food(Name, categorySelected, Description, Price, Recipe, WhichRadioButtonIsChecked());
							MenuStore.CreateNewMenuItem(obj);
						} else
						{
							MenuItem obj = new Drink(Name, categorySelected, Description, Price, Recipe, WhichRadioButtonIsChecked());
							MenuStore.CreateNewMenuItem(obj);
						}
						MessageBox.Show("Added successfully");

					}
					else
					{
						if(TypeSelected == "Food")
						{
							MenuItem obj = new Food(Name, categorySelected, Description, Price, Recipe);
							MenuStore.CreateNewMenuItem(obj);
						}else
						{
							MenuItem obj = new Drink(Name, categorySelected, Description, Price, Recipe);
							MenuStore.CreateNewMenuItem(obj);
						}
						MessageBox.Show("Added successfully");


					}



				}
				else
				{
					MessageBox.Show("Ju lutem shkrauni cmimin dhe id e kateogrise numer!");
				}
			}
			else
			{
				MessageBox.Show("Ju lutem mbushni te gjitha Fushat !!");
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

		public void ShowNewItemsInDropdown(string foodordrink)
		{
			cmbKateoriMenu.Items.Clear();
			var b = "";
			foreach (var item in Category.AllCategories)
			{
				if (item.FoodOrDrink == foodordrink)
				{
					b = item.CategoryName;
					cmbKateoriMenu.Items.Add(b);
				}
			}
		}

		private void btnShtoKategori_Click(object sender, EventArgs e)
		{
			if (txtAddCategoryId.Text.Length >= 1 && txtAddCategoryName.Text.Length >= 1 && cmbCategoryType.Text.Length>=1)
			{
				if (isValidNumber(txtAddCategoryId.Text))
				{
					if (!Category.CanCreateCategory(int.Parse(txtAddCategoryId.Text)))
					{
						MessageBox.Show("Tashme Ekziston nje kategori me kete Id");
					}
					else
					{

						Category.AddNewCategory(new Category(int.Parse(txtAddCategoryId.Text), txtAddCategoryName.Text,CategoryType));
						cmbKateoriMenu.Items.Clear();
					    ShowNewItemsInDropdown(TypeSelected == "Drink" ? "Drink" : "Food");
						txtAddCategoryId.Text = string.Empty;
						txtAddCategoryName.Text = string.Empty;
						cmbCategoryType.Text = string.Empty;
						MessageBox.Show("Kategoria u shtua me sukses");
					}
				}
				else
					MessageBox.Show("Shkruani Id numer Valid!");


			}
			else
			{
				MessageBox.Show("Ju lutem mbushni te gjitha fushat !");
			}
		}

		private void btnShowRadioButton_Click(object sender, EventArgs e)
		{
			visible = !visible;
			btnShowRadioButton.Text = visible ? "Anulo Madhesin" : "Zgjedh madhesin";
			rdMadhe.Visible = visible;
			rdMesme.Visible = visible;
			rdVogel.Visible = visible;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbKateoriMenu.Items.Clear();
			TypeSelected = cmbType.Text;
			if (TypeSelected == "Drink")
			{
				ShowNewItemsInDropdown("Drink");
			}else
			{
				ShowNewItemsInDropdown("Food");

			}
		}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			CategoryType = cmbCategoryType.Text;
		}

		private void btnHome_Click(object sender, EventArgs e)
		{

			Form1 form1 = new Form1();
			this.Hide();
			form1.ShowDialog();
			this.Close();
		}

		private void cmbKateoriMenu_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (var item in Category.AllCategories)
			{
				if(item.CategoryName == cmbKateoriMenu.Text)
				{
					categorySelected = item;

				}
			}
			
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			this.Hide();
			MenuForm formMenu = new MenuForm();
			formMenu.ShowDialog();
			this.Close();


		}

		private void btnNavAddTable_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddTable form = new AddTable();
			form.ShowDialog();
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

		private void btnNavAddMenu_Click(object sender, EventArgs e)
		{

		}

		private void txtAddCategoryId_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtAddCategoryName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
