using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Info
{
	public sealed class AccountDetails : Account, IAccountInfo
	{
		public string ID { get; set; }
		public AccountType AccountTypes { get; set; }
		public double Balance { get; set; }

		public double GetBalance()
		{
			return Balance;
		}

		public void ShowAccountDetails()
		{
			Console.WriteLine("ID : " + ID);
			Console.WriteLine("Name : " + Name);
			Console.WriteLine("Account Number : " + AccountNumber);
			Console.WriteLine("Current Balance : " + GetBalance());
			Console.WriteLine("Account Type : " + AccountTypes);
			Console.WriteLine("Account Create Date : " + CreateDate.ToString("dddd, dd MMMM yyyy"));
		}
	}
}
