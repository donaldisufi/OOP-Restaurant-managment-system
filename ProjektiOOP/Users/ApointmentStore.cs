using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOP.Users
{
	public static class ApointmentStore
	{
		public static List<Apointemnt> AllApointment = new List<Apointemnt>();


	    public static void AddNewApointment(Apointemnt a )
		{
			AllApointment.Add(a);
		}

		public static List<Apointemnt> AvailableApointments()
		{
			List<Apointemnt> list = new List<Apointemnt>();
			foreach (var item in AllApointment)
			{
				if (DateTime.Now < item.Data)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}
}