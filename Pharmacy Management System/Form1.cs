using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHARMACY_DEPENDENCY;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        List<MEDICINE> medicines = new List<MEDICINE>();
        ACCOUNT shop_account = new ACCOUNT();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buyMedicineButton_Click(object sender, EventArgs e)
        {
            string name = buyMedicineNameTextBox.Text;
            string id = buyMedicineBuyPrice.Text;
            int quantity = Convert.ToInt32(buyMedicineQuantityTextBox.Text);
            double buyPrice = Convert.ToDouble(buyMedicineBuyPrice.Text);
            double sellPrice = Convert.ToDouble(buyMedicineSellPrice.Text);

            bool med_exists = false;
            MEDICINE dummy_medicine = new MEDICINE();


            for (int i = 0; i < medicines.Count; i++)
            {
                if (name == medicines[i].medicineName && medicines[i].medicineAmount > 0)
                {
                    med_exists = true;


                }
            }

            if (med_exists == true)
            {
                for (int i = 0; i < medicines.Count; i++)
                {
                    if (name == medicines[i].medicineName)
                    {
                        medicines[i].medicineAmount += quantity;
                        


                    }
                }

                MessageBox.Show("Medicine Bought.");

            }
            else
            {
                dummy_medicine.medicineName = name;
                dummy_medicine.medicineAmount = quantity;
                dummy_medicine.sellPrice = sellPrice;
                dummy_medicine.buyPrice = buyPrice;
                if (quantity * buyPrice < shop_account.accountBalance)
                {
                    medicines.Add(dummy_medicine);
                    shop_account.accountBalance -= quantity * buyPrice;
                    MessageBox.Show("Successfully Bought Medicine.");
                    
                }
                else
                {
                    MessageBox.Show("Not enough fund.");
                }
            }

            



                

        }

        private void sellMedicineButton_Click(object sender, EventArgs e)
        {
            string name = sellMedicineNametextBox.Text;
            int amount = Convert.ToInt32(sellMedicineQuantityTextBox.Text);
            

            bool med_exists = false;
            
            
            for (int i = 0; i < medicines.Count; i++)
            {
                if (name == medicines[i].medicineName && medicines[i].medicineAmount > 0)
                {
                    med_exists = true;
                }
            }
            
            if (med_exists == true )
            {
                for (int i = 0; i < medicines.Count; i++)
                {
                    if (name == medicines[i].medicineName)
                    {
                        medicines[i].medicineAmount-=amount;
                        shop_account.accountBalance += (medicines[i].sellPrice)*amount;
                        

                    }
                }
        
                MessageBox.Show("Medicine Sold");

            }
            else
            {
                MessageBox.Show("Medicine not available.");
            }
        }

        private void checkAccountBalanceButton_Click(object sender, EventArgs e)
        {
            showAccountBalanceLabel.Text =":BDT  "+ Convert.ToString(shop_account.accountBalance);
        }

        private void checkFullStockButton_Click(object sender, EventArgs e)
        {
            showStockListBox.Items.Clear();
            for (int i = 0; i < medicines.Count; i++)
            {
                showStockListBox.Items.Add(medicines[i].getMedicineInfo() + "\n");

            }
        }

        private void checkStockButton_Click(object sender, EventArgs e)
        {
            string name = checkStockNameTextBox.Text;
            string id = checkStockIdTextBox.Text;
           


            bool med_exists = false;


            for (int i = 0; i < medicines.Count; i++)
            {
                if (name == medicines[i].medicineName && medicines[i].medicineAmount > 0)
                {
                    med_exists = true;
                }
            }

            if (med_exists == true)
            {
                for (int i = 0; i < medicines.Count; i++)
                {
                    if (name == medicines[i].medicineName)
                    {
                        showStockListBox.Items.Clear();
                        showStockListBox.Items.Add(medicines[i].getMedicineInfo());
                        break;

                    }
                }

                

            }
            else
            {
                MessageBox.Show("Medicine not available.");
            }
        }
    }
    }

