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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Set the form's start position to CenterScreen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sourceDirectory = txtSourceDirectory.Text;
            string targetDirectory = txtTargetDirectory.Text;
            string fileName = txtFileName.Text;

            string sourceFilePath = Path.Combine(sourceDirectory, fileName);
            string targetFilePath = Path.Combine(targetDirectory, fileName);

            try
            {
                File.Copy(sourceFilePath, targetFilePath, true);
                MessageBox.Show("File copied successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
