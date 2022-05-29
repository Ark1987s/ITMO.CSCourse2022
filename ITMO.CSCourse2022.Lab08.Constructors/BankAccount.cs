using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2022.Lab08.Constructors
{
    class BankAccount
    {
		private long accNo;
		private decimal accBal;
		private AccountType accType;
		private static long nextNumber = 123;
		public BankAccount()
		{
			accNo = NextNumber();
			accType = AccountType.Checking;
			accBal = 0;
		}
		public BankAccount(AccountType aType)
		{
			accNo = NextNumber();
			accType = aType;
			accBal = 0;
		}
		public BankAccount(decimal aBal)
		{
			accNo = NextNumber();
			accType = AccountType.Checking;
			accBal = aBal;
		}
		public BankAccount(AccountType aType, decimal aBal)
		{
			accNo = NextNumber();
			accType = aType;
			accBal = aBal;
		}
		public long Number()
		{
			return accNo;
		}
		public decimal Balance()
		{
			return accBal;
		}
		public string Type()
		{
			return accType.ToString();
		}
		private static long NextNumber()
		{
			return nextNumber++;
		}
	}
}
