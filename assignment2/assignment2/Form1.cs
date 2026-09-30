using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resturentorder_Click(object sender, EventArgs e)
        {

        }

        private void btnresult_Click(object sender, EventArgs e)

        {
            //entering data
            try
            {
                
                string order1, order2, all_recorded;
                double Price1, Price2,total;
                order1=txtitem1.Text;
                order2 = txtitem2.Text; 
                Price1=double.Parse(price1.Text);
                Price2=double.Parse(price2.Text);
                total=Price1 + Price2;
                double tax = total * 0.07;
                all_recorded ="total"+ total+"Tax "+tax;
                lbloutput.Text=all_recorded;

            } 
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //clearing all data

        private void button1_Click(object sender, EventArgs e)
        {
            txtitem1.Clear();
            txtitem2.Clear();
            price1.Clear();
            price2.Clear();
            lbloutput.Text = " ";



        }
    }
}
