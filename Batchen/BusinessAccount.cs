using System;
using System.Collections.Generic;
using System.Text;

namespace Batchen
{
    internal class BusinessAccount : CheckingAccount
    {
        private string title;
        public string GetTitle() { return this.title; }
        public void SetTitle(string title) { this.title = title; }
        public BusinessAccount(string title, int bankID, int branchID, int accountID, string customerID)
        : base(bankID, branchID, accountID, customerID) { this.title = title; }
        public BusinessAccount(string title, int bankID, int branchID, int accountID, string customerID, double creditLimit)
        : base(bankID, branchID, accountID, customerID, creditLimit) { this.title = title; }
        public override string ToString()
        {
            return "Business Title: " + this.title + "\n" + base.ToString();
        }
        public bool FundsTransfer(double amount, BasicAccount account)
        {
            bool b = base.Withdrawal(amount);
            if (b) { account.Deposit(amount); }
            return b;
        }



        public static void UnitTests()
        {
            BusinessAccount ba0 = new BusinessAccount("Clinic", 9, 99, 9999, "Dr.J", 500);
            ba0.Deposit(1000);
            Console.WriteLine(ba0);
            Console.WriteLine("----------------------------------------------");
            CheckingAccount ba1 = new CheckingAccount(17, 1717, 171717, "Josh");
            Console.WriteLine(ba1);
            Console.WriteLine("----------------------------------------------");
            int cash = 2000;
            Console.WriteLine("Try Transfer " + cash);
            if (ba0.FundsTransfer(cash, ba1))
                Console.WriteLine(ba1);
            else
                Console.WriteLine("Can't do Transfer!");
            Console.WriteLine("----------------------------------------------");
            cash = 1017;
            Console.WriteLine("Try Transfer " + cash);
            ba0.FundsTransfer(cash, ba1);
            Console.WriteLine(ba0);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(ba1);
            Console.WriteLine("----------------------------------------------");
        }
    }
}
