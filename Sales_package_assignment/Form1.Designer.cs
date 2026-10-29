namespace assignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnumberofoackage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.existbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnumberofoackage
            // 
            this.txtnumberofoackage.Location = new System.Drawing.Point(214, 62);
            this.txtnumberofoackage.Name = "txtnumberofoackage";
            this.txtnumberofoackage.Size = new System.Drawing.Size(288, 26);
            this.txtnumberofoackage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "PURCHASE INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of package";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price Perpckage";
            // 
            // calculatebtn
            // 
            this.calculatebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.calculatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.calculatebtn.Location = new System.Drawing.Point(29, 161);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(153, 59);
            this.calculatebtn.TabIndex = 5;
            this.calculatebtn.Text = "CALCULATE";
            this.calculatebtn.UseVisualStyleBackColor = false;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.Black;
            this.clearbtn.Location = new System.Drawing.Point(197, 161);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(138, 59);
            this.clearbtn.TabIndex = 6;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // existbtn
            // 
            this.existbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.existbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existbtn.ForeColor = System.Drawing.Color.Black;
            this.existbtn.Location = new System.Drawing.Point(364, 161);
            this.existbtn.Name = "existbtn";
            this.existbtn.Size = new System.Drawing.Size(138, 59);
            this.existbtn.TabIndex = 7;
            this.existbtn.Text = "EXIT";
            this.existbtn.UseVisualStyleBackColor = false;
            this.existbtn.Click += new System.EventHandler(this.existbtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(584, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 384);
            this.listBox1.TabIndex = 8;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(214, 117);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(288, 26);
            this.txtprice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 468);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.existbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumberofoackage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumberofoackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculatebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button existbtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtprice;
    }
}

