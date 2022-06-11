namespace cpFiles
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
            this.lblSelectFolder = new System.Windows.Forms.Label();
            this.txtSelectFolder = new System.Windows.Forms.TextBox();
            this.lblTargetFolder = new System.Windows.Forms.Label();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileExtension = new System.Windows.Forms.TextBox();
            this.btnRun2Copy = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblSelectFolder
            // 
            this.lblSelectFolder.AutoSize = true;
            this.lblSelectFolder.Location = new System.Drawing.Point(34, 47);
            this.lblSelectFolder.Name = "lblSelectFolder";
            this.lblSelectFolder.Size = new System.Drawing.Size(62, 12);
            this.lblSelectFolder.TabIndex = 0;
            this.lblSelectFolder.Text = "SelectFolder";
            // 
            // txtSelectFolder
            // 
            this.txtSelectFolder.Location = new System.Drawing.Point(116, 47);
            this.txtSelectFolder.Name = "txtSelectFolder";
            this.txtSelectFolder.Size = new System.Drawing.Size(357, 22);
            this.txtSelectFolder.TabIndex = 1;
            // 
            // lblTargetFolder
            // 
            this.lblTargetFolder.AutoSize = true;
            this.lblTargetFolder.Location = new System.Drawing.Point(31, 101);
            this.lblTargetFolder.Name = "lblTargetFolder";
            this.lblTargetFolder.Size = new System.Drawing.Size(65, 12);
            this.lblTargetFolder.TabIndex = 2;
            this.lblTargetFolder.Text = "TargetFolder";
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Location = new System.Drawing.Point(116, 96);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.Size = new System.Drawing.Size(357, 22);
            this.txtTargetFolder.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SelectFolder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "SelectFolder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "FileExtension";
            // 
            // txtFileExtension
            // 
            this.txtFileExtension.Location = new System.Drawing.Point(116, 144);
            this.txtFileExtension.Name = "txtFileExtension";
            this.txtFileExtension.Size = new System.Drawing.Size(357, 22);
            this.txtFileExtension.TabIndex = 7;
            this.txtFileExtension.Text = "*.txt";
            // 
            // btnRun2Copy
            // 
            this.btnRun2Copy.Location = new System.Drawing.Point(36, 210);
            this.btnRun2Copy.Name = "btnRun2Copy";
            this.btnRun2Copy.Size = new System.Drawing.Size(75, 23);
            this.btnRun2Copy.TabIndex = 8;
            this.btnRun2Copy.Text = "Run2Copy";
            this.btnRun2Copy.UseVisualStyleBackColor = true;
            this.btnRun2Copy.Click += new System.EventHandler(this.btnRun2Copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 265);
            this.Controls.Add(this.btnRun2Copy);
            this.Controls.Add(this.txtFileExtension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTargetFolder);
            this.Controls.Add(this.lblTargetFolder);
            this.Controls.Add(this.txtSelectFolder);
            this.Controls.Add(this.lblSelectFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectFolder;
        private System.Windows.Forms.TextBox txtSelectFolder;
        private System.Windows.Forms.Label lblTargetFolder;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileExtension;
        private System.Windows.Forms.Button btnRun2Copy;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

