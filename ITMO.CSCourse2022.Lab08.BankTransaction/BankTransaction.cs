using System;

namespace ITMO.CSCourse2022.Lab08.BankTransaction
{
    public class BankTransaction
    {
        private readonly decimal amount;
        private readonly DateTime when;
        public decimal Amount()
        {
            return amount;
        }
        public DateTime When()
        {
            return when;
        }
        public BankTransaction(decimal tranAmount)
        {
            amount = tranAmount;
            when = DateTime.Now;
        }
    }
}
     
    