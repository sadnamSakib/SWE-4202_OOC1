using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laundry_Dependencies;

namespace Laundry_Management_System
{
    public partial class Form1 : Form
    {
        LMS lms = new LMS();
        public Form1()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(setStatusOrderIdTextBox.Text);
            
            for (int i = 0; i < lms.orders.Count; i++)
            {
                if (id == lms.orders[i].orderId)
                {

                    lms.orders[i].setStatus(setStatusComboBox.Text);
                    
                }
            }
            currentBalanceLabel.Text = "Current Balance : " + Convert.ToString(ACCOUNTS.fund);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            user.userName = createUserUserNameTextBox.Text;
            user.userId = createUserUserIdTextBox.Text;
            user.userAdddress = createUserUserAddressTextBox.Text;
            lms.users.Add(user);
            MessageBox.Show("USER ADDED");
            
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            string id = placeOrderUserIdTextBox.Text;
            for(int i = 0; i < lms.users.Count; i++)
            {
                if(id== lms.users[i].userId)
                {
                    lms.users[i].userBedSheet = Convert.ToInt32(placeOrderBedTextBox.Text);
                    lms.users[i].userShirt = Convert.ToInt32(placeOrderShirtTextBox.Text);
                    lms.users[i].userPant = Convert.ToInt32(placeOrderPantTextBox.Text);
                    lms.users[i].userSuit = Convert.ToInt32(placeOrderSuitTextBox.Text);
                    lms.users[i].shirtToDo = shirtComboBox.Text;
                    lms.users[i].pantToDo = pantComboBox.Text;
                    lms.users[i].suitToDo = suitComboBox.Text;
                    lms.users[i].BedSheetToDo = bedComboBox.Text;
                    string temp = Convert.ToString(ACCOUNTS.orderID);
                    MessageBox.Show("Order Placed.Order ID - " + temp);
                    int price = 0;
                    if(shirtComboBox.Text != "")
                    {   
                        if(shirtComboBox.Text == "Both")
                        {
                            price += 60*Convert.ToInt32(placeOrderShirtTextBox.Text);
                        }
                        else if(shirtComboBox.Text == "Wash")
                        {
                            price += 50*Convert.ToInt32(placeOrderShirtTextBox.Text);
                        }
                        else
                        {
                            price += 10*Convert.ToInt32(placeOrderShirtTextBox.Text);
                        }
                    }
                    if (pantComboBox.Text != "")

                    {
                        if (pantComboBox.Text == "Both")
                        {
                            price += 60*Convert.ToInt32(placeOrderPantTextBox.Text);
                        }
                        else if (pantComboBox.Text == "Wash")
                        {
                            price += 50*Convert.ToInt32(placeOrderPantTextBox.Text);
                        }
                        else
                        {
                            price += 10*Convert.ToInt32(placeOrderPantTextBox.Text);
                        }
                    }
                    if (suitComboBox.Text != "")
                    {
                        if (suitComboBox.Text == "Both")
                        {
                            price += 60*Convert.ToInt32(placeOrderSuitTextBox.Text);
                        }
                        else if (suitComboBox.Text == "Wash")
                        {
                            price += 50*Convert.ToInt32(placeOrderSuitTextBox.Text);
                        }
                        else
                        {
                            price += 10*Convert.ToInt32(placeOrderSuitTextBox.Text);
                        }
                    }
                    if (bedComboBox.Text != "")
                    {
                        if (bedComboBox.Text == "Both")
                        {
                            price += 60*Convert.ToInt32(placeOrderSuitTextBox.Text);
                        }
                        else if (bedComboBox.Text == "Wash")
                        {
                            price += 50*Convert.ToInt32(placeOrderSuitTextBox.Text);
                        }
                        else
                        {
                            price += 10*Convert.ToInt32(placeOrderSuitTextBox.Text);
                        }
                    }
                     lms.users[i].amount += price;
                    ACCOUNTS.fund += price;

                    ORDER order = new ORDER();
                    order.setUser(lms.users[i]);
                    order.setOrderId(ACCOUNTS.orderID);
                    lms.orders.Add(order);

                    ACCOUNTS.orderID++;
                    break;


                }
                else
                {
                    MessageBox.Show("User Not Registered.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(seeOrderIdTexBox.Text);
            detailesListBox.Items.Clear();
            for (int i = 0; i < lms.orders.Count; i++)
            {
                if (id == lms.orders[i].orderId)
                {

                    detailesListBox.Items.Add(lms.orders[i].listShow());
                    amountLabel.Text = " Amount : " + Convert.ToString(lms.orders[i].user.amount);
                    statusLabel.Text = "Status : " + lms.orders[i].status;
                    nameLabel.Text = "Name : " + lms.orders[i].user.userName;
                    addressLabel.Text = "Address : " + lms.orders[i].user.userAdddress;
                }
            }
        }
    }
}
