using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        public BankAccount()
        {

        }
        private double balance;

        public BankAccount(double _balance)
        {
            balance = _balance;
        }



        public void Deposit(double x)
        {
            balance = balance + x;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
