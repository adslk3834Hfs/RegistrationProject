using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
	public class Accounts
	{
		public List<User> ourAccounts { get; set; }

		public Accounts()
		{
			ourAccounts = new List<User>();
		}
		public void AddUser(User user)
		{
			ourAccounts.Add(user);
		}
		public void RemoveUser(User user)
		{
			ourAccounts.Remove(user);
		}
		public void Print()
		{			
			foreach(User person in ourAccounts)
			{
				person.Print();
			}
		}
	}
}
