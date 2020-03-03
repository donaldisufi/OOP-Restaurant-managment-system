using ProjektiOOP.Employees;
using ProjektiOOP.Menus;
using ProjektiOOP.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Orders
{
	public class Order
	{
		public static int Index { get; private set; } = 0;
		public int OrderId { get; set; }
		public Table Table { get; set; }
		public DateTime Date { get; set; }
		public bool IsOrderCompleted { get; set; }
		public List<OrderDetail> OrderItemsList { get; private set; }
		public Employee Employe;

		public Order(Table table, DateTime date,Employee emp)
		{
			OrderId = Index;
			Table = table;
			Date = date;
			OrderItemsList = new List<OrderDetail>();
			Employe = emp;
			table.ChangeAvailablityTable(false);
			Index++;
			IsOrderCompleted = false;
		}
		
		public void CompleteOrder()
		{
			IsOrderCompleted = true;
		}

		public void AddMenuItemsinOrder(MenuItem item, int quantity)
		{
			bool check = true;
			foreach(var obj in OrderItemsList)
			{
				if(item == obj.Item)
				{
					obj.Quantity += quantity;
					check = false;
				}
			}
			if (check)
			{
				OrderItemsList.Add(new OrderDetail(item, quantity));
			}
		}
		public void RemoveMenuIteminOrderList(int Id)
		{
			foreach (var item in OrderItemsList)
			{
				if (item.Id == Id)
				{
					if (item.Quantity > 1)
					{
						item.Quantity -= 1;
					}else
					{
						OrderItemsList.Remove(item);
					}
				}
			}
		}

		public class OrderDetail
		{
			static int index = 0;
			public MenuItem Item;
			public int Quantity;
			public int Id;


			public OrderDetail(MenuItem item, int quantity)
			{
				index++;
				Item = item;
				Quantity = quantity;
				Id = index;
			}
			
		}

	}
}
