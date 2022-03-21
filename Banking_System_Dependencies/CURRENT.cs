using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Dependencies
{
    public class CURRENT:ACCOUNTS
    {
        public string suffix = "300";
        public int minBalance = 500;
        public int minAmount = 0;
        public int withdrawCharge = 0;
        public int maxTransaction = 100000;
        public int lim = int.MaxValue;

        public override int withdraw(int n)
        {
            if (this.accountBalance - n < minBalance)
            {
                return 0;
            }
            else
            {
                this.accountBalance -= n;
                return 1;
            }
        }

        
    }
}
