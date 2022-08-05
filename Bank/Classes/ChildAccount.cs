using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Interfaces;

namespace Bank.Classes
{
    public class ChildAccount:PrimaryAccount
    {
        public override string addBalance(double amount)
        {
            if (amount <= 1000)
            {
                return base.addBalance(amount);
            }
            else
            {
                return "Maximum Transaction Limit of the child account is 1000 only";
            }
        }
        public override string display()
        {
            return $"Bank\n account No:{accountNo}\n account type : Child Account\n balance:{balance}";
        }
    }

}
