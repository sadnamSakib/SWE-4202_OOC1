using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2_Accounting
{
    internal class Program
    {
        public class ACCOUNT
        {
            private string accountNO;
            private string accountName;
            private float balance;
            public static int id = 1;
            public string AccountNO
            {
                get { return accountNO; }
                set { accountNO = value; }
            }
            public string AccountName
            {
                get { return accountName; }
                set { accountName = value; }
            }
            public float Balance
            {
                get { return balance; }
                set { balance = value; }
            }

        }

        public class CurrentAccount : ACCOUNT
        {
            public static int serviceCharge=100;
            public static string accountPrefix = 100;
            
            public static void nextAccount()
            {
                string temp = accountPrefix +"-"+ Convert.ToString(ACCOUNT.id);
                ACCOUNT.id++;
            }
            

        }

        public class SavingsAccount : ACCOUNT
        {
            private float InterestRate;
            private float monthlyDepositAmount;
            public static string accountPrefix = "200";

            public static void nextAccount()
            {
                string temp = accountPrefix + "-" + Convert.ToString(ACCOUNT.id);
                ACCOUNT.id++;
            }
            public float interestrate
            {
                get { return InterestRate; }
                set { InterestRate = value; }
            }
            public float deposit
            {
                get { return monthlyDepositAmount; }
                set { monthlyDepositAmount = value; }
            }


        }

        public class MonthlyDepositScheme : ACCOUNT
        {
            private float InterestRate;
            private float monthlyDepositAmount;
            public static string accountPrefix = "300";

            public static void nextAccount()
            {
                string temp = accountPrefix + "-" + Convert.ToString(ACCOUNT.id);
                ACCOUNT.id++;
            }
            public float interestrate
            {
                get { return InterestRate; }
                set { InterestRate = value; }
            }
            public float deposit
            {
                get { return monthlyDepositAmount; }
                set { monthlyDepositAmount = value; }
            }


        }

        public class LoanAccount : ACCOUNT
        {
            private float InterestRate;
            private float monthlyDepositAmount;
            public static string accountPrefix = "900";

            public static void nextAccount()
            {
                string temp = accountPrefix + "-" + Convert.ToString(ACCOUNT.id);
                ACCOUNT.id++;
            }
            public float interestrate
            {
                get { return InterestRate; }
                set { InterestRate = value; }
            }
            public float deposit
            {
                get { return monthlyDepositAmount; }
                set { monthlyDepositAmount = value; }
            }


        }

        public class TwoYearMDS: MonthlyDepositScheme
        {
            private float maximumInterest;
            public float max
            {
                get { return maximumInterest; }
                set { maximumInterest = value; }
            }
        }
        public class FiveYearDMS : MonthlyDepositScheme
        {
            private float maximumInterest;
            public float max
            {
                get { return maximumInterest; }
                set { maximumInterest = value; }
            }
        }
        public class InitialDepositMDS : MonthlyDepositScheme
        {
            private float maximumInterest;
            private float initialDepositAmount;
            public float max
            {
                get { return maximumInterest; }
                set { maximumInterest = value; }
            }
            public float initial
            {
                get { return initialDepositAmount; }
                set { initialDepositAmount = value; }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
