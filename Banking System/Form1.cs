using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking_System_Dependencies;

namespace Banking_System
{
    public partial class Form1 : Form

    {
        public Bank bank = new Bank();
        public class negativeException : ApplicationException
        {
            public override string Message
            {
                get
                {
                    return "Negative Amount Inputed";
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = createAccountComboBox.Text;
            if (type == "SAVINGS")
            {
                SAVINGS dummy_savings = new SAVINGS();
                dummy_savings.accountNo = Convert.ToString(bank.ac);
                dummy_savings.accountNo += dummy_savings.suffix;
                dummy_savings.accountOwner = createAccountName.Text;
                dummy_savings.contactNumber = createAccountContact.Text;
                bank.ac++;
                bank.savingsAccounts.Add(dummy_savings);
               
                
            }
            else if (type == "LOAN")
            {
                LOAN dummy_loan = new LOAN();
                dummy_loan.accountNo = Convert.ToString(bank.ac);
                dummy_loan.accountNo += dummy_loan.suffix;
                dummy_loan.accountOwner = createAccountName.Text;
                dummy_loan.contactNumber = createAccountContact.Text;
                bank.ac++;
                bank.loanAccounts.Add(dummy_loan);
            }
            else
            {
                CURRENT dummy_current = new CURRENT();
                dummy_current.accountNo = Convert.ToString(bank.ac);
                dummy_current.accountNo += dummy_current.suffix;
                dummy_current.accountOwner = createAccountName.Text;
                dummy_current.contactNumber = createAccountContact.Text;
                bank.ac++;
                bank.currentAccounts.Add(dummy_current);
            }
            MessageBox.Show("Account Created");
        }

        private void transactionActionButton_Click(object sender, EventArgs e)
        {
            string acno = transactionAccountNoTextBox.Text;
            string type = transactionAccountTypeComboBox.Text;
            string action = transactionActionConboBox.Text;
            int amount = Convert.ToInt32(transactionAmountComboBox.Text);
            if (amount < 0)
            {
                throw new negativeException();
            }
            if (type == "SAVINGS")
            {
                for(int i = 0; i < bank.savingsAccounts.Count; i++)
                {
                    if (acno == bank.savingsAccounts[i].accountNo)
                    {
                        if (action == "DEPOSIT")
                        {
                            bank.savingsAccounts[i].deposit(amount);
                        }
                        else if(action == "WITHDRAW")
                        {
                            bank.savingsAccounts[i].withdraw(amount);
                        }
                        break;
                    }
                }
            }
            else if(type == "LOAN")
            {
                for (int i = 0; i < bank.loanAccounts.Count; i++)
                {
                    if (acno == bank.loanAccounts[i].accountNo)
                    {
                        if (action == "DEPOSIT")
                        {
                            bank.loanAccounts[i].deposit(amount);
                        }
                        else
                        {
                            bank.loanAccounts[i].loan(amount);
                        }
                        break;
                        
                    }
                }
            }
            else
            {
                for (int i = 0; i < bank.currentAccounts.Count; i++)
                {
                    if (acno == bank.currentAccounts[i].accountNo)
                    {
                        if (action == "DEPOSIT")
                        {
                            bank.currentAccounts[i].deposit(amount);
                            string transdetails = "Deposit\t" + transactionAmountComboBox.Text;
                            transdetails += DateTime.Now.ToString("h:mm:ss tt");
                        }
                        else if (action == "WITHDRAW")
                        {
                            bank.currentAccounts[i].withdraw(amount);
                        }
                        break;
                    }
                }
            }
            MessageBox.Show("Transaction Successful");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
