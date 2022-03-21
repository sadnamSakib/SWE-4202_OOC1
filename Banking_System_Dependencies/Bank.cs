using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Dependencies
{
    public class Bank
    {
       
        public int ac = 1;
        public List<CURRENT> currentAccounts = new List<CURRENT>();
        public List<SAVINGS> savingsAccounts = new List<SAVINGS>();
        public List<LOAN> loanAccounts = new List<LOAN>();
        
    }
}
