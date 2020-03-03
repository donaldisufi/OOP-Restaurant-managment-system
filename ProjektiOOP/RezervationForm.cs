using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektiOOP.Components;
using ProjektiOOP.Users;

namespace ProjektiOOP
{
	public partial class RezervationForm : Form
	{
		public RezervationForm()
		{
			InitializeComponent();
			LoadRezervs();
		
			
		}
		public void LoadRezervs()
		{
			mainPanel.Controls.Clear();
			ReservationContainer obj; //347 hieght
			int x = 5;
			int y = 1;
			foreach (var item in ApointmentStore.AllApointment)
			{
				obj = new ReservationContainer(item);
				obj.Location = new Point(x, y);
				x += 269;
				mainPanel.Controls.Add(obj);
			}
		}

		private void RezervationForm_Load(object sender, EventArgs e)
		{
			//262

		}

		private void button2_Click(object sender, EventArgs e)
		{
			LoadRezervs();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Form1 res = new Form1();
			this.Hide();
			res.ShowDialog();
			this.Close();
		}
	}
}
