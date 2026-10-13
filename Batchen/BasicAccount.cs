using System;
using System.Collections.Generic;
using System.Text;

namespace Batchen
{
    public class BasicAccount
    {
        private int bankID;
        private int branchID;
        private int accountID;
        private string customerID;
        private double balance;

        public BasicAccount(int bankID, int branchID, int accountID, string customerID)
        {
            this.bankID = bankID;
            this.branchID = branchID;
            this.accountID = accountID;
            this.customerID = customerID;
            this.balance = 0;
        }
        public int GetBankID() { return this.bankID; }
        public int GetBranchID() { return this.branchID; }
        public int GetAccountID() { return this.accountID; }
        public double GetBalance() { return this.balance; }
        public string GetCustomerID() { return this.customerID; }
        protected void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public override string ToString()
        {
            string s = "Account details:\n";
            s += "================\n";
            s += $"Bank#{this.bankID}, Branch#{this.branchID}, Account#{this.accountID}\n";
            s += $"Customer: {this.customerID}, Balance: {this.balance}";
            return s;
        }
        public bool Deposit(double amount)
        {
            bool result = false;
            if (amount > 0)
            {
                this.balance += amount;
                result = true;
            }
            return result;
        }



        public static void UnitTests()
        {
            BasicAccount ba1 = new BasicAccount(17, 1717, 171717, "Josh");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(ba1);
            Console.WriteLine("----------------------------------------------");
            int cash = -17;
            if (ba1.Deposit(cash))
                Console.WriteLine(ba1);
            else
                Console.WriteLine($"Can't Deposit {cash} !!");
            Console.WriteLine("----------------------------------------------");
            cash = 17000017;
            if (ba1.Deposit(cash))
                Console.WriteLine(ba1);
            else
                Console.WriteLine($"Can't Deposit {cash} !!");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
