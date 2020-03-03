using ProjektiOOP.Employees;
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
	public partial class Signup : Form
	{
		public Signup()
		{
			InitializeComponent();
		}

		private void btnUser_Click(object sender, EventArgs e)
		{

			string name = txtName.Text;
			string email = txtEmail.Text;
			string password = txtPassword.Text;
			if(name.Trim().Length>=3 && email.Trim().Length>=5 && password.Trim().Length >= 4)
			{
				if (UserStore.CanCreateUser(email))
				{
					User obj = new User(email, password, name);
					UserStore.AddNewUser(obj);
					TempEmployee.currentUser = obj;
					UserStack usr = new UserStack();
					this.Hide();
					usr.ShowDialog();
					this.Close();
				}else
				{
					MessageBox.Show("Kjo email ekziston tashme !");
				}
			}


		}

		private void Signup_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Login usr = new Login();
			this.Hide();
			usr.ShowDialog();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LoginUser usr = new LoginUser();
			this.Hide();
			usr.ShowDialog();
			this.Close();
		}
	}
}
