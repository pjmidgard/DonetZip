namespace dzordz_1._0._0._0__
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnZipFolder = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(54, 26);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(484, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnZipFolder
            // 
            this.btnZipFolder.Location = new System.Drawing.Point(586, 24);
            this.btnZipFolder.Name = "btnZipFolder";
            this.btnZipFolder.Size = new System.Drawing.Size(86, 23);
            this.btnZipFolder.TabIndex = 3;
            this.btnZipFolder.Text = "compression";
            this.btnZipFolder.UseVisualStyleBackColor = true;
            this.btnZipFolder.Click += new System.EventHandler(this.btnZipFolder_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(544, 23);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(36, 23);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(54, 52);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(484, 23);
            this.progressBar.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 87);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnZipFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dzord_1.0.0.1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnZipFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

