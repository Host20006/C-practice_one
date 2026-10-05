namespace WindowsFormsApp3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lplaverage = new System.Windows.Forms.Label();
            this.txttest3 = new System.Windows.Forms.Label();
            this.txttest2 = new System.Windows.Forms.Label();
            this.txttest1 = new System.Windows.Forms.Label();
            this.AVG = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear_click = new System.Windows.Forms.Button();
            this.btnExit_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(295, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(295, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(295, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // lplaverage
            // 
            this.lplaverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lplaverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lplaverage.Location = new System.Drawing.Point(267, 194);
            this.lplaverage.Name = "lplaverage";
            this.lplaverage.Size = new System.Drawing.Size(155, 47);
            this.lplaverage.TabIndex = 4;
            // 
            // txttest3
            // 
            this.txttest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttest3.Location = new System.Drawing.Point(158, 150);
            this.txttest3.Name = "txttest3";
            this.txttest3.Size = new System.Drawing.Size(118, 23);
            this.txttest3.TabIndex = 5;
            this.txttest3.Text = "TEXT SCORE3#";
            // 
            // txttest2
            // 
            this.txttest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttest2.Location = new System.Drawing.Point(158, 106);
            this.txttest2.Name = "txttest2";
            this.txttest2.Size = new System.Drawing.Size(118, 23);
            this.txttest2.TabIndex = 6;
            this.txttest2.Text = "TEXT SCORE2#";
            // 
            // txttest1
            // 
            this.txttest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttest1.Location = new System.Drawing.Point(158, 61);
            this.txttest1.Name = "txttest1";
            this.txttest1.Size = new System.Drawing.Size(118, 23);
            this.txttest1.TabIndex = 7;
            this.txttest1.Text = "TEXT SCORE1#";
            // 
            // AVG
            // 
            this.AVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVG.Location = new System.Drawing.Point(167, 206);
            this.AVG.Name = "AVG";
            this.AVG.Size = new System.Drawing.Size(84, 23);
            this.AVG.TabIndex = 9;
            this.AVG.Text = "AVERAGE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 79);
            this.button1.TabIndex = 10;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear_click
            // 
            this.btnClear_click.Location = new System.Drawing.Point(320, 254);
            this.btnClear_click.Name = "btnClear_click";
            this.btnClear_click.Size = new System.Drawing.Size(75, 40);
            this.btnClear_click.TabIndex = 11;
            this.btnClear_click.Text = "CLEAR";
            this.btnClear_click.UseVisualStyleBackColor = true;
            // 
            // btnExit_click
            // 
            this.btnExit_click.Location = new System.Drawing.Point(320, 300);
            this.btnExit_click.Name = "btnExit_click";
            this.btnExit_click.Size = new System.Drawing.Size(75, 33);
            this.btnExit_click.TabIndex = 12;
            this.btnExit_click.Text = "EXIST";
            this.btnExit_click.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btnExit_click);
            this.Controls.Add(this.btnClear_click);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AVG);
            this.Controls.Add(this.txttest1);
            this.Controls.Add(this.txttest2);
            this.Controls.Add(this.txttest3);
            this.Controls.Add(this.lplaverage);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lplaverage;
        private System.Windows.Forms.Label txttest3;
        private System.Windows.Forms.Label txttest2;
        private System.Windows.Forms.Label txttest1;
        private System.Windows.Forms.Label AVG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear_click;
        private System.Windows.Forms.Button btnExit_click;
    }
}

