using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {
        
            private void btncalcualate_Click(object sender, EventArgs e)
        {
            try
            {
                double test1 = double.Parse(textBox1.Text);
                double test2 = double.Parse(textBox4.Text);
                double test3 = double.Parse(textBox3.Text);

                double Average = (test1 + test2 + test3) / 3;

                if (Average >= 0)
                {
                    lplaverage.Text = Average.ToString("n1");
                }
                else
                {
                    lplaverage.Text = "Invalid";
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           textBox4.Clear();
            textBox3.Clear();
            lplaverage.Text = "";
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        
    

