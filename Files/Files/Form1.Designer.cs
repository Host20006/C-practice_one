namespace Files
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnappend = new System.Windows.Forms.Button();
            this.btnreading = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(293, 35);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(220, 147);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File Dialog";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(293, 396);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(220, 147);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Clear Listbox";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(293, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 147);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(553, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 529);
            this.listBox1.TabIndex = 3;
            // 
            // btnappend
            // 
            this.btnappend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappend.Location = new System.Drawing.Point(27, 212);
            this.btnappend.Name = "btnappend";
            this.btnappend.Size = new System.Drawing.Size(220, 147);
            this.btnappend.TabIndex = 9;
            this.btnappend.Text = "Append";
            this.btnappend.UseVisualStyleBackColor = true;
            this.btnappend.Click += new System.EventHandler(this.btnappend_Click);
            // 
            // btnreading
            // 
            this.btnreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreading.Location = new System.Drawing.Point(27, 396);
            this.btnreading.Name = "btnreading";
            this.btnreading.Size = new System.Drawing.Size(220, 147);
            this.btnreading.TabIndex = 8;
            this.btnreading.Text = "Reading";
            this.btnreading.UseVisualStyleBackColor = true;
            this.btnreading.Click += new System.EventHandler(this.btnreading_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.Location = new System.Drawing.Point(27, 35);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(220, 147);
            this.btnCreateFile.TabIndex = 7;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 614);
            this.Controls.Add(this.btnappend);
            this.Controls.Add(this.btnreading);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnappend;
        private System.Windows.Forms.Button btnreading;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

