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

namespace File_Copier_App
{
    public partial class CopyAllFiles : Form
    {
        public CopyAllFiles()
        {
            InitializeComponent();

            // Set the form's start position to CenterScreen
            this.StartPosition = FormStartPosition.CenterScreen;
        }
       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sourceDirectory = txtSourceDirectory.Text;
            string targetDirectory = txtTargetDirectory.Text;

            if (string.IsNullOrEmpty(sourceDirectory) || string.IsNullOrEmpty(sourceDirectory) || string.IsNullOrEmpty(sourceDirectory))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            try
            {
                // Get the list of files in the source directory
                string[] files = Directory.GetFiles(sourceDirectory);

                // Copy each file to the target directory
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string targetPath = Path.Combine(targetDirectory, fileName);
                    File.Copy(file, targetPath, true); // Set overwrite to true to replace existing files
                }

                MessageBox.Show("Files copied successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
