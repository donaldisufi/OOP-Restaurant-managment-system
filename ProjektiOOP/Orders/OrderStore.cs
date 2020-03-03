using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Orders
{
	public static class OrderStore
	{
		public static List<Order> AllOrders { get; private set; } = new List<Order>();

		public static void CreateNewOrder(Order order)
		{
			AllOrders.Add(order);
		}

		public static List<Order> ReturnOrdersWithScpecificDate(DateTime date)
		{
			List<Order> list = new List<Order>();
			foreach (var item in list)
			{
				if(item.Date.ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
				{
					list.Add(item);
				}
			}
			return list;
		}
		public static List<Order> GetUnCompletedOrders()
		{
			List<Order> temp = new List<Order>();
			foreach (var item in AllOrders)
			{
				if (!item.IsOrderCompleted)
				{
					temp.Add(item);
				}
			}
			return temp;
		}
		public static List<Order> GetAllCompletedOrders()
		{
			List<Order> temp = new List<Order>();
			foreach (var item in AllOrders)
			{
				if (item.IsOrderCompleted)
				{
					temp.Add(item);
				}
			}
			return temp;
		}
		 

		
	}
}
