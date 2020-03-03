using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektiOOP.Orders;

namespace ProjektiOOP.Components
{
	public partial class OrderContainer : UserControl
	{

		Order myOrder;
		public OrderContainer()
		{
			InitializeComponent();
		}
		public OrderContainer(Order order)
		{
			InitializeComponent();
			myOrder = order;
			panMainPanel.Controls.Clear();
			int x = 5;
			int y = 5;
			OrderDetailContainer obj;
			foreach (var item in myOrder.OrderItemsList)
			{
			    obj = new OrderDetailContainer(myOrder, item);
				obj.Location = new Point(x, y);
				panMainPanel.Controls.Add(obj);
				x += 60;
			}
			lblNumber.Text = myOrder.OrderId.ToString();
			lblTable.Text = myOrder.Table.TableNumber.ToString();
			lblPuntori.Text = myOrder.Employe.Name;

		}

		private void OrderContainer_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			panMainPanel.Controls.Clear();
			int x = 5;
			int y = 5;
			OrderDetailContainer obj;
			foreach (var item in myOrder.OrderItemsList)
			{
				obj = new OrderDetailContainer(myOrder, item);
				obj.Location = new Point(x, y);
				panMainPanel.Controls.Add(obj);
				x += 60;
			}
		}

		private void btnPerfundo_Click(object sender, EventArgs e)
		{
			try
			{
				myOrder.CompleteOrder();
			   MessageBox.Show("Porosia u perfundua me sukses \n \t Shtyp Refresh per tu rifreskuar .");
			}
			catch (Exception ex)
			{

			}
		}
	}
}
