using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_click_Click(object sender, EventArgs e)
        {
            private void btncalculate_Click(object sender, EventArgs e)
        {
            double hoursWorked;
            double hourlyPayRate;

            if (hoursWorkedTextBox.Text == "")
            {
                MessageBox.Show("Please enter hours worked.");
            }
            else
            {
                if (hourlyPayRateTextBox.Text == "")
                {
                    MessageBox.Show("Please enter hourly pay rate.");
                }
                else
                {
                    if (!double.TryParse(hoursWorkedTextBox.Text, out hoursWorked))
                    {
                        MessageBox.Show("Please enter valid hours worked.");
                    }
                    else
                    {
                        if (!double.TryParse(hourlyPayRateTextBox.Text, out hourlyPayRate))
                        {
                            MessageBox.Show("Please enter valid hourly pay rate.");
                        }
                        else
                        {
                            double grossPay;

                            if (hoursWorked <= 40)
                            {
                                grossPay = hoursWorked * hourlyPayRate;
                            }
                            else
                            {
                                double overtimeHours = hoursWorked - 40;
                                double overtimePay = overtimeHours * hourlyPayRate * 1.5;
                                grossPay = (40 * hourlyPayRate) + overtimePay;
                            }

                            lplgrosspay.Text = grossPay.ToString("C");
                        }
                    }
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            lplgrosspay.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void btnClear_click_Click(object sender, EventArgs e)
        {

        }
    }
}
