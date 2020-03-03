using ProjektiOOP.Employees;
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

namespace ProjektiOOP
{
	public partial class UserStack : Form
	{
		Table selectedTable;
		DateTime data;
		public UserStack()
		{
			InitializeComponent();
			lblWelcome.Text = "Welcome  " + TempEmployee.currentUser.Name;
			loadTables();

		}

		private void UserStack_Load(object sender, EventArgs e)
		{

		}

		private void cmbTAble_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (var item in TableStore.AllTabels)
			{
				if (item.TableNumber.ToString() == cmbTable.Text)
				{
					selectedTable = item;
				
				}
			}
		}
		public void loadTables()
		{
			cmbTable.Items.Clear();
			foreach (var item in TableStore.AllTabels)
			{
				cmbTable.Items.Add(item.TableNumber.ToString());
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

		private void ctnReservo_Click(object sender, EventArgs e)
		{
			if (isValidNumber(txtPersons.Text) && selectedTable != null && data != null)
			{
				ApointmentStore.AddNewApointment(new Apointemnt(selectedTable, data, TempEmployee.currentUser, int.Parse(txtPersons.Text)));
				MessageBox.Show("Rezervimi u krye me sukses");
				txtPersons.Clear();
				dtData.Text = "";
				cmbTable.Items.Clear();
				cmbTable.Text = "";
				loadTables();
			}
		}

		private void dtData_ValueChanged(object sender, EventArgs e)
		{
			data = DateTime.Parse(dtData.Text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TempEmployee.currentUser = null;

			Login res = new Login();
			this.Hide();
			res.ShowDialog();
			this.Close();
		}
	}
}
