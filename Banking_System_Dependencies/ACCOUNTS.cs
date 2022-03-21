using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Dependencies
{
    public class ACCOUNTS
    {
        public string accountOwner;
        public string accountNo;
        public string contactNumber;
        public int accountBalance = 0;
        public List<string> transactions = new List<string>();
        public virtual int deposit(int n)
        {
            accountBalance += n;
            return 1;
        }

        public virtual int withdraw(int n)
        {
            accountBalance -= n;
            return 1;
        }

        public string getinfo()
        {
            string info = this.accountOwner + "\t" + this.accountNo + "\t" + this.accountBalance;
            return info;
        }
        
    }
}
