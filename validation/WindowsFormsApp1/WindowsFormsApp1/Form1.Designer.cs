namespace WindowsFormsApp1
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
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lplgrosspay = new System.Windows.Forms.Label();
            this.btncalculate_click = new System.Windows.Forms.Button();
            this.btnClear_click = new System.Windows.Forms.Button();
            this.existButton_click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(205, 72);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(177, 20);
            this.hoursWorkedTextBox.TabIndex = 0;
            this.hoursWorkedTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(205, 111);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(177, 20);
            this.hourlyPayRateTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hours Worked";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lplgrosspay
            // 
            this.lplgrosspay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lplgrosspay.Location = new System.Drawing.Point(205, 154);
            this.lplgrosspay.Name = "lplgrosspay";
            this.lplgrosspay.Size = new System.Drawing.Size(176, 45);
            this.lplgrosspay.TabIndex = 4;
            // 
            // btncalculate_click
            // 
            this.btncalculate_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate_click.Location = new System.Drawing.Point(116, 215);
            this.btncalculate_click.Name = "btncalculate_click";
            this.btncalculate_click.Size = new System.Drawing.Size(92, 53);
            this.btncalculate_click.TabIndex = 5;
            this.btncalculate_click.Text = "Calculate Gross Pay";
            this.btncalculate_click.UseVisualStyleBackColor = true;
            this.btncalculate_click.Click += new System.EventHandler(this.btncalculate_click_Click);
            // 
            // btnClear_click
            // 
            this.btnClear_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_click.Location = new System.Drawing.Point(236, 230);
            this.btnClear_click.Name = "btnClear_click";
            this.btnClear_click.Size = new System.Drawing.Size(82, 23);
            this.btnClear_click.TabIndex = 6;
            this.btnClear_click.Text = "Clear";
            this.btnClear_click.UseVisualStyleBackColor = true;
            this.btnClear_click.Click += new System.EventHandler(this.btnClear_click_Click);
            // 
            // existButton_click
            // 
            this.existButton_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existButton_click.Location = new System.Drawing.Point(346, 230);
            this.existButton_click.Name = "existButton_click";
            this.existButton_click.Size = new System.Drawing.Size(82, 23);
            this.existButton_click.TabIndex = 7;
            this.existButton_click.Text = "Exist";
            this.existButton_click.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hourly Pay Rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gross Pay";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.existButton_click);
            this.Controls.Add(this.btnClear_click);
            this.Controls.Add(this.btncalculate_click);
            this.Controls.Add(this.lplgrosspay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lplgrosspay;
        private System.Windows.Forms.Button btncalculate_click;
        private System.Windows.Forms.Button btnClear_click;
        private System.Windows.Forms.Button existButton_click;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

