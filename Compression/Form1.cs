using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dzordz_1._0._0._0__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            //Select folder
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select your path.";
            if (fbd.ShowDialog() == DialogResult.OK)
                txtFolder.Text = fbd.SelectedPath;
        }



        private void btnZipFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Please select your folder.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFolder.Focus();
                return;
            }
            string path = txtFolder.Text;
            //Zip folder & update progress bar
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    zip.AddDirectory(path);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
                    zip.SaveProgress += Zip_SaveProgress;
                    zip.Save(string.Format(".zip", di.Parent.FullName, di.Name));
                }
            }) { IsBackground = true };
            thread.Start();
        }

        private void Zip_SaveProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = e.EntriesTotal;
                    progressBar.Value = e.EntriesSaved + 1;
                    progressBar.Update();
                }));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

}
