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
	public partial class LoginUser : Form
	{
		public LoginUser()
		{
			InitializeComponent();
		}

		private void LoginUser_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string email = txtEmail.Text;
			string pass = txtPassword.Text;

			if(email.Length >=4 && pass.Length >= 4)
			{
				if (UserStore.Login(email, pass))
				{
					TempEmployee.currentUser = UserStore.GetUserByEmail(email);
					UserStack res = new UserStack();
					this.Hide();
					res.ShowDialog();
					this.Close();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Signup res = new Signup();
			this.Hide();
			res.ShowDialog();
			this.Close();
		}
	}
}
