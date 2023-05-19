using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Info
{
	public abstract class Account
	{
		public string Name { get; set; }
		public long AccountNumber { get; set; }
		public DateTime CreateDate { get; set; }
	}
}
