using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Interfaces;

namespace Bank.Classes
{
    public class PrimaryAccount:IPrint
    {
        static int no=0;
        protected int accountNo;
        protected double balance;
        public double Balance
        {
            set
            {
                Balance = value;
            }
            get
            {
                return balance;
            }
        }
        public PrimaryAccount()
        {
            no++;
            accountNo = no;
        }
        public PrimaryAccount(int b)
        {
            balance = b;
            no++;
            accountNo = no;
        }
        public virtual string addBalance(double amount)
        {
            if (balance >= 500 && balance + amount <= 500)
            {
                return $"Your balance has reached the limit\n Cannot withraw {amount} Balanace is {balance}";
            }
            else
            {
                balance = balance + amount;
                return $"Sucessful Bank balance is {balance}";
                
            }
        }

        public virtual string display()
        {
            return $"Bank\n account No:{accountNo}\n account type : Primary Account\n balance:{balance}";
        }
    }
}
