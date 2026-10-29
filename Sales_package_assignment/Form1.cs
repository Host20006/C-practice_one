using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatebtn_Click(object sender, EventArgs e, string numberof_packege)

        {


            




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            // clearing the Textboxes
            listBox1.Items.Clear();
            txtnumberofoackage.Text = "";
            txtprice.Text = "";
           
        }

        private void existbtn_Click(object sender, EventArgs e)
        {
            //Exiting the hole program
            this.Close();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                int numberofPackages;
                double price;
                double subTotal;
                double DiscountRate = 0;
                double DiscountAmount = 0;
                double TotalAmount;

                // validate using tryparse
                if (!int.TryParse(txtnumberofoackage.Text, out numberofPackages) ||
                    !double.TryParse(txtprice.Text, out price))
                {
                    MessageBox.Show("enter only numeric data");
                    return;
                }

                if (numberofPackages <= 0 || price <= 0)
                {
                    MessageBox.Show("you can't enter a negative/zero package & negative/zero price");
                    return;
                }

                // calculating  subtotal
                subTotal = numberofPackages * price;


                // calculating discount
                if (numberofPackages >= 10 && numberofPackages <= 19)
                {
                    DiscountAmount = subTotal * 0.2;
                    DiscountRate = 20;
                }
                else if (numberofPackages >= 20 && numberofPackages <= 49)
                {
                    DiscountAmount = subTotal * 0.3;
                    DiscountRate = 30;
                }
                else if (numberofPackages >= 50 && numberofPackages <= 99)
                {
                    DiscountAmount = subTotal * 0.4;
                    DiscountRate = 40;
                }
                else if (numberofPackages >= 100)
                {
                    DiscountAmount = subTotal * 0.5;
                    DiscountRate = 50;
                }
                // calculating TOTAL
                TotalAmount = subTotal - DiscountAmount;

                // all output
                listBox1.Items.Add("Number of Packages: " + numberofPackages);
                listBox1.Items.Add("Price per package:" + price);
                listBox1.Items.Add("Subtotal (before discount):" + subTotal);
                listBox1.Items.Add("Discount Rate:" + DiscountRate);
                listBox1.Items.Add("Discount Amount:" + DiscountAmount);
                listBox1.Items.Add("Total Amount (after discount):" + TotalAmount);




















            }
            catch (Exception ex)
            {
                MessageBox.Show("don't enter invalid data ");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
