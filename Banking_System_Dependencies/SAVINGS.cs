using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Dependencies
{
    public class SAVINGS:ACCOUNTS
    {
        public string suffix = "314";
        public int minBalance = 0;
        public int minAmount = 50000;
        public int withdrawCharge = 0;
        public int maxTransaction = int.MaxValue;
        public int lim = 5;
        public override int deposit(int n)
        {
            if(this.accountBalance ==0 && n >= this.minAmount)
            {
                this.accountBalance += n;
            }
            else if(this.accountBalance != 0)
            {
                this.accountBalance += n;
            }
            else
            {
                return 0;
            }
            return 1;
        }

        public override int withdraw(int n)
        {
            this.lim--;
            if (this.lim >= 0)
            {
                this.accountBalance -= n;
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }
}
