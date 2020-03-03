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
using static ProjektiOOP.Orders.Order;

namespace ProjektiOOP.Components
{
	public partial class OrderDetailContainer : UserControl
	{
		public Order myOrder;
		public OrderDetail myDetail;

		public OrderDetailContainer()
		{
			InitializeComponent();
		}
		public OrderDetailContainer(Order order , OrderDetail item )
		{
			InitializeComponent();
			myOrder = order;
			myDetail = item;
			txtName.Text = item.Item.ItemName;
			txtQuantity.Text = item.Quantity.ToString();
			txtPrice.Text = item.Item.Price.ToString() + " $";
			txtTotalPrice.Text = (item.Item.Price * item.Quantity).ToString()+ " $";
		}

		private void OrderDetailContainer_Load(object sender, EventArgs e)	
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
			  myOrder.RemoveMenuIteminOrderList(myDetail.Id);
			  MessageBox.Show("Produkti u fshiu \n \t shtyp Refresh per ti rifreskuar !");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Nje gabim ka ndodh , produkti nuk eshte fshire");
			}
			
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void txtTotalPrice_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPrice_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtQuantity_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
