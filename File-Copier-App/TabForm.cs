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
    public partial class TabForm : Form
    {
        public TabForm()
        {
            InitializeComponent();

            // Set the form's start position to CenterScreen
            this.StartPosition = FormStartPosition.CenterScreen;
        }
       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sourceDirectory = txtSourceDirectory_1.Text;
            string targetDirectory = txtTargetDirectory_1.Text;

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
                    string targetFilePath = Path.Combine(targetDirectory, fileName);

                    bool IsOveride = checkBoxOverride_1.Checked;

                    if (IsOveride)
                    {
                        File.Copy(file, targetFilePath, true); // Set overwrite to true to replace existing files
                    }
                    else
                    {
                        // Check if the file already exists in the target directory
                        if (File.Exists(targetFilePath))
                        {
                            // Generate a new file name with a numbering scheme
                            int count = 1;
                            string newFileName;
                            do
                            {
                                newFileName = $"{Path.GetFileNameWithoutExtension(fileName)} ({count++}){Path.GetExtension(fileName)}";
                                targetFilePath = Path.Combine(targetDirectory, newFileName);
                            } while (File.Exists(targetFilePath));
                        }

                        File.Copy(file, targetFilePath); // Copy the file
                    }
                }

                MessageBox.Show("Files copied successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSubmit_2_Click(object sender, EventArgs e)
        {
            string sourceDirectory = txtSourceDirectory_1.Text;
            string targetDirectory = txtTargetDirectory_1.Text;
            string fileName = txtFileName_2.Text;

            if (string.IsNullOrEmpty(sourceDirectory) || string.IsNullOrEmpty(sourceDirectory) || string.IsNullOrEmpty(sourceDirectory))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            string sourceFilePath = Path.Combine(sourceDirectory, fileName);
            string targetFilePath = Path.Combine(targetDirectory, fileName);

            try
            {
                bool IsOveride = checkBoxOverride_2.Checked;

                if (IsOveride)
                {
                     File.Copy(sourceFilePath, targetFilePath, true); // Set overwrite to true to replace existing files
                }
                else
                    {
                    // Check if the file already exists in the target directory
                    if (File.Exists(targetFilePath))
                    {
                        // Generate a new file name with a numbering scheme
                        int count = 1;
                        string newFileName;
                        do
                        {
                            newFileName = $"{Path.GetFileNameWithoutExtension(fileName)} ({count++}){Path.GetExtension(fileName)}";
                            targetFilePath = Path.Combine(targetDirectory, newFileName);
                        } while (File.Exists(targetFilePath));
                    }

                    File.Copy(sourceFilePath, targetFilePath); // Copy the file
                }

                MessageBox.Show("File copied successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

    }
}
