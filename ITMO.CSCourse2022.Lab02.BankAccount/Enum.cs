using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2022.Lab02.BankAccount
{
    public enum AccountType { Cheking, Deposit }
    internal class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Cheking;
            platinumAccount = AccountType.Deposit;
            Console.WriteLine("The Customer Account  Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account  Type is {0}", platinumAccount);
        }
    }
}
