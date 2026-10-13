using System;
using System.Collections.Generic;
using System.Text;

namespace Batchen
{
    public class SavingAccount : BasicAccount
    {
        private Date endDate;
        public SavingAccount(int bankID, int branchID, int accountID, string customerID, Date endDate)
            : base(bankID, branchID, accountID, customerID)
        {
            this.endDate = new Date(endDate);
        }
        public Date GetEndDate() { return new Date(endDate); }
        public override string ToString()
        {
            return base.ToString() + "\nSaving End Date ... " + this.GetEndDate().ToString();
        }
        public bool Withdrawal(Date date)
        {
            bool result = false;
            if (date.CompareTo(this.endDate) >= 0)
            {
                base.SetBalance(0);
                result = true;
            }
            return result;
        }


        public static void UnitTests()
        {
            SavingAccount ba1 = new SavingAccount(17, 1717, 171717, "Josh", new Date());
            ba1.Deposit(1000);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(ba1);
            Console.WriteLine("----------------------------------------------");
            Date d = new Date();
            d.SetYear(d.GetYear() - 1);
            Console.WriteLine("Try withdraw too early...");
            if (ba1.Withdrawal(d))
                Console.WriteLine(ba1);
            else
                Console.WriteLine("Can't do withdrawal!");
            Console.WriteLine("----------------------------------------------");
            d.SetYear(d.GetYear() + 2);
            Console.WriteLine("Try withdraw on time...");
            ba1.Withdrawal(d);
            Console.WriteLine(ba1);
            Console.WriteLine("----------------------------------------------");
        }
    }
}
