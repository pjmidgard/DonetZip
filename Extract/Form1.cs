using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Download and unzip the DotNetZip library at: http://dotnetzip.codeplex.com/
// Add a reference to the Ionic.Zip.dll library.

using System.IO;
using Ionic.Zip;

namespace howto_use_dotnetzip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Start with an initial file.
        private void Form1_Load(object sender, EventArgs e)
        {
          
            txtExtractTo.Text = Path.GetFullPath(
                Path.Combine(Application.StartupPath, "..\\..\\ExtractedFiles\\"));
        }

        

        // Extract the files from the archive.
        private void btnExtractArchive_Click(object sender, EventArgs e)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(txtArchiveName.Text))
                {
                    // Loop through the archive's files.
                    foreach (ZipEntry zip_entry in zip)
                    {
                        zip_entry.Extract(txtExtractTo.Text);
                    }
                }

                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error extracting archive.\n" + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
