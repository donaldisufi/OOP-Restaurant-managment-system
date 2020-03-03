using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektiOOP.Users;

namespace ProjektiOOP.Components
{
	public partial class ReservationContainer : UserControl
	{
		public Apointemnt rezervimi;

		public ReservationContainer()
		{
			InitializeComponent();
		}
		public ReservationContainer(Apointemnt obj)
		{
			InitializeComponent();
			rezervimi = obj;
			lblEmri.Text = rezervimi.user.Name;
			lblKontakti.Text = rezervimi.user.Email;
			lblPersonat.Text = rezervimi.PersonsNumber.ToString();
			lblRezervimi.Text = rezervimi.ID.ToString();

			btnData.Text = rezervimi.Data.ToString();
			btnTable.Text = rezervimi.table.TableNumber.ToString();
		}

		private void ReservationContainer_Load(object sender, EventArgs e)
		{

		}
	}
}
