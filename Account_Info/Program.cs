using Account_Info;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("=========Account Info===========");
		AccountDetails ad = new AccountDetails()
		{
			ID = "001",
			Name = "Easin Alif",
			AccountNumber = 14215185629,
			CreateDate = DateTime.Today.AddYears(-2),
			AccountTypes = AccountType.SavingsAccount,
			Balance = 200000.00
		};
		ad.ShowAccountDetails();
		Console.WriteLine();
		Console.WriteLine("==========Second Account Info==========");
		AccountDetails ad2 = new AccountDetails()
		{
			ID = "002",
			Name = "Nusrat Arora",
			AccountNumber = 14215185630,
			CreateDate = DateTime.Today.AddYears(-5),
			AccountTypes = AccountType.FixedDepositAccount,
			Balance = 15000000.00
		};
		ad2.ShowAccountDetails();

		GC.Collect();
		Console.ReadKey();
	}
}