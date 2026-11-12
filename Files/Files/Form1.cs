using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Result;

            Result = openFileDialog1.ShowDialog();

            if (Result == DialogResult.OK)
            {
                MessageBox.Show("Waad soo Furatay File kaaga");

                string fileName = openFileDialog1.FileName;

                MessageBox.Show(fileName);
            }
            else if (Result == DialogResult.Cancel)
            {
                MessageBox.Show("Madadan soo furin file");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            ///import classes - creating 
            StreamWriter OutputFile;

            // Open the file 
            //creating New file - CreateText()
            OutputFile = File.CreateText("Ca242.txt");

            //process the file 
            // Creating New file - createText()
            OutputFile.WriteLine("Best Class In Semester 5 is CA242");
            OutputFile.Write("Jamhuuriya University ");
            OutputFile.WriteLine("Subject C#");

            //the close 
            OutputFile.Close();
            MessageBox.Show("Sucessfull To Create");

            // Open the file 
            //creating New file - CreateText()
            OutputFile = File.CreateText("Ca244.txt");

            //process the file 
            // Creating New file - createText()
            OutputFile.WriteLine("Best Class In Semester 5 is CA244");
            OutputFile.WriteLine("Jamhuuriya University ");
            OutputFile.Write("Subject Java");

            //the close 
            OutputFile.Close();
            MessageBox.Show("Sucessfull To Create");
        }

        private void btnreading_Click(object sender, EventArgs e)
        {
            // reading  the file

            // import class

            StreamReader Reads;

            DialogResult Result;

            Result = openFileDialog1.ShowDialog();

            if (Result == DialogResult.OK)
            {
                //Read the file 

                Reads = File.OpenText(@"C:\Users\sadri\OneDrive\Desktop\c#\chapter1\First example chapter1\Files\Files\bin\Debug\Ca242.txt");

                //Process the file 
                string lines;

                //check the file is end 
                while (Reads.EndOfStream == false)
                {
                    lines = Reads.ReadLine();
                    listBox1.Items.Add(lines);

                }

                Reads.Close();

            }
            else if (Result == DialogResult.Cancel)
            {
                MessageBox.Show("not open the file ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnappend_Click(object sender, EventArgs e)
        {
            StreamWriter OutputFile;

            DialogResult Result;

            Result = openFileDialog1.ShowDialog();

            if (Result == DialogResult.OK)
            {
                OutputFile = File.AppendText(openFileDialog1.FileName);

                // Process the file
                OutputFile.WriteLine("Data Structure java ");
                OutputFile.WriteLine("c#");
                OutputFile.WriteLine("Networking");

                OutputFile.Close();

                MessageBox.Show("Xogta Cusub Waa lagu soo daray");
            }
            else if (Result == DialogResult.Cancel)
            {
                MessageBox.Show("Ma doran wax file ah");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter writes;

            DialogResult result;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";

            result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                writes = File.AppendText(saveFileDialog.FileName);

                // process the file - writing the file 
                writes.WriteLine("fasalkaan hadaa waxbaraneynin iska bax");
                writes.WriteLine("fasalkaan waxaa laga rabaa dad wax baranaayo");

                //close
                writes.Close();

                MessageBox.Show("Faylka waa save garey Xog cusub ayaa lagu daray xogti hore waa lagu kor daray");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("canceled");
            }
        }
    }
}
