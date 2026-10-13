using System;
using System.Collections.Generic;
using System.Text;

namespace Batchen
{
    public class CheckingAccount : BasicAccount
    {
        private const double DEFAULT_CREDIT_LIMIT = 0;
        private double creditLimit;
        public double GetCreditLimit() { return this.creditLimit; }
        public void SetCreditLimit(double creditLimit)
        {
            if (creditLimit > 0)
                this.creditLimit = creditLimit;
        }
        public CheckingAccount(int bankID, int branchID, int accountID, string customerID)
            : this(bankID, branchID, accountID, customerID, CheckingAccount.DEFAULT_CREDIT_LIMIT) { }
        public CheckingAccount(int bankID, int branchID, int accountID, string customerID, double creditLimit)
            : base(bankID, branchID, accountID, customerID)
        {
            this.creditLimit = creditLimit;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCredit Limit is: {this.creditLimit}";
        }

        public bool Withdrawal(double amount)
        {
            bool result = false;
            if (amount > 0)
            {
                if (base.GetBalance() + this.creditLimit >= amount)
                {
                    base.SetBalance(base.GetBalance() - amount);
                    result = true;
                }
            }
            return result;
        }


        public static void UnitTests()
        {
            CheckingAccount ba1 = new CheckingAccount(17, 1717, 171717, "Josh", 500);
            ba1.Deposit(1000);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(ba1);
            Console.WriteLine("----------------------------------------------");
            int cash = 2000;
            Console.WriteLine("Try withdraw " + cash);
            if (ba1.Withdrawal(cash))
                Console.WriteLine(ba1);
            else
                Console.WriteLine("Can't do withdrawal!");
            Console.WriteLine("----------------------------------------------");
            cash = 1017;
            Console.WriteLine("Try withdraw " + cash);
            ba1.Withdrawal(cash);
            Console.WriteLine(ba1);
            Console.WriteLine("----------------------------------------------");
        }
    }
}
