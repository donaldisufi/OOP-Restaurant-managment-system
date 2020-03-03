using ProjektiOOP.Employees;
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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void btnAdmin_Click(object sender, EventArgs e)
		{
			if(txtEmail.Text.Length>=4 && txtPasword.Text.Length >= 4)
			{
				var obj =EmployesStore.GetEmployeeByEmail(txtEmail.Text);
				if(obj != null)
				{
					if(EmployesStore.Authenticate(txtEmail.Text,txtPasword.Text))
					{
						TempEmployee.currentEmployee = obj;
						Form1 res = new Form1();
						this.Hide();
						res.ShowDialog();
						this.Close();
					}
				}else
				{
					MessageBox.Show("Te dhenat jane gabim");
				}
			}
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			Signup res = new Signup();
			this.Hide();
			res.ShowDialog();
			this.Close();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void txtPasword_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
