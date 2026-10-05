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
            this.txtNumber = new System.Windows.Forms.Label();
            this.lblRangeDecision = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckQualificatin_click = new System.Windows.Forms.Button();
            this.btnClear_click = new System.Windows.Forms.Button();
            this.btnExist_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Location = new System.Drawing.Point(197, 41);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(228, 23);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.UseWaitCursor = true;
            // 
            // lblRangeDecision
            // 
            this.lblRangeDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRangeDecision.Location = new System.Drawing.Point(173, 116);
            this.lblRangeDecision.Name = "lblRangeDecision";
            this.lblRangeDecision.Size = new System.Drawing.Size(285, 23);
            this.lblRangeDecision.TabIndex = 1;
            this.lblRangeDecision.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter an integerin the range of 1 through 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Range Decision";
            // 
            // btnCheckQualificatin_click
            // 
            this.btnCheckQualificatin_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckQualificatin_click.Location = new System.Drawing.Point(197, 178);
            this.btnCheckQualificatin_click.Name = "btnCheckQualificatin_click";
            this.btnCheckQualificatin_click.Size = new System.Drawing.Size(112, 66);
            this.btnCheckQualificatin_click.TabIndex = 4;
            this.btnCheckQualificatin_click.Text = "Checking Qualification";
            this.btnCheckQualificatin_click.UseVisualStyleBackColor = true;
            this.btnCheckQualificatin_click.Click += new System.EventHandler(this.btnCheckQualificatin_click_Click);
            // 
            // btnClear_click
            // 
            this.btnClear_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_click.Location = new System.Drawing.Point(339, 178);
            this.btnClear_click.Name = "btnClear_click";
            this.btnClear_click.Size = new System.Drawing.Size(75, 30);
            this.btnClear_click.TabIndex = 5;
            this.btnClear_click.Text = "Clear";
            this.btnClear_click.UseVisualStyleBackColor = true;
            // 
            // btnExist_Click
            // 
            this.btnExist_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist_Click.Location = new System.Drawing.Point(339, 214);
            this.btnExist_Click.Name = "btnExist_Click";
            this.btnExist_Click.Size = new System.Drawing.Size(75, 30);
            this.btnExist_Click.TabIndex = 6;
            this.btnExist_Click.Text = "Exist";
            this.btnExist_Click.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.btnExist_Click);
            this.Controls.Add(this.btnClear_click);
            this.Controls.Add(this.btnCheckQualificatin_click);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRangeDecision);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNumber;
        private System.Windows.Forms.Label lblRangeDecision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckQualificatin_click;
        private System.Windows.Forms.Button btnClear_click;
        private System.Windows.Forms.Button btnExist_Click;
    }
}

