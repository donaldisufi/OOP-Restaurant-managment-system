using ProjektiOOP.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjektiOOP.Orders.Order;

namespace ProjektiOOP.Orders
{
	public static class OrdersCalculator
	{

		public static OrderDetail FindThemostSoldProduct(List<Order> SpecificOrderList)
		{
			List<OrderDetail> TempOrderList = GetTheUniqueDetailListOfAllOrders(SpecificOrderList);
			int length = GetOrderLength(TempOrderList);
			if (length >= 1)
			{
				int i = 0;
				OrderDetail temp = TempOrderList[0];
				foreach (var item in TempOrderList)
				{
					if (i != 0)
					{
						if (item.Quantity > temp.Quantity)
						{
							temp = item;
						}
					}
					i++;

				}
				return temp;
			}
			return null;
		}

		private static List<OrderDetail> GetTheUniqueDetailListOfAllOrders(List<Order> SpecificList)
		{
			List<OrderDetail> TempList = new List<OrderDetail>();
			//Iterimi mrena cdo Order(Porosi)
			int j = 0;
			foreach(var item in SpecificList)
			{   //Veq nese OdrerDetails e qasaj Order , ka prodkute nto
				if (j == 0)
				{
					foreach (var obk in item.OrderItemsList)
					{
						TempList.Add(obk);
					}
				}
				else
				{
					int length = GetOrderLength(item.OrderItemsList);
					if (length >= 1)
					{
						int i = 0;
						foreach (var obj in item.OrderItemsList)
						{
							bool check = true;
							foreach (var k in TempList)
							{
								if (obj == k)
								{
									k.Quantity += obj.Quantity;
									check = false;
								}
							}
							if (check)
							{
								TempList.Add(obj);
							}
							i++;
						}
					}
				}
				j++;
			}



			return TempList;
		}



	 //   public static OrderDetail GoInsideAnOrder(Order order1)
		//{
		//	Order order = order1;
		//	int length = GetOrderLength(order.OrderItemsList);
		//	if (length >= 1)
		//	{
		//		OrderDetail item = order.OrderItemsList[0];
		//		List<OrderDetail> ListaUnique = new List<OrderDetail>();
		//		int i = 0;
		//		foreach (var obj in order.OrderItemsList)
		//		{
		//			if (i != 0)
		//			{
		//				if(item.Item == obj.Item)
		//				{
		//					item.Quantity += obj.Quantity;
		//					ListaUnique.Add(item);
		//				}else if (obj.Quantity > item.Quantity)
		//				{
		//					item = obj;
		//				}
		//				ListaUnique.Add(obj);
		//			}
					
		//			i++;
		//		}
		//		return item;
		//	}
		//	return null;
		//} 

		//static List<OrderDetail> KtheListenUnike(List<OrderDetail> Lista)
		//{
		//	List<OrderDetail> newLista = new List<OrderDetail>();
		//	int length = GetOrderLength(Lista);
		//	if (length >= 1)
		//	{
		//		int i = 0;
		//		OrderDetail o = Lista[0];
		//		foreach (var item in Lista)
		//		{
		//			if (i != 0)
		//			{
		//				bool check = true;
		//				foreach (var objec in newLista)
		//				{
		//					if (objec == item)
		//					{
		//						check = false;
		//						objec.Quantity += item.Quantity;
		//					}
		//				}
		//				if (check)
		//				{
		//					newLista.Add(item);
		//				}
		//			}
		//			else
		//			{
		//				newLista.Add(item);
		//			}
		//			i++;
		//		}
		//	}
		//	return newLista;
		//}

		
		private static int GetOrderLength(List<OrderDetail> lista)
		{
			int i = 0;
			foreach (var item in lista)
			{
				i++;
			}
			return i;
		}
		
	}

}
