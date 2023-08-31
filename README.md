# Creating a Desktop Application in .NET using Visual Studio 2019

This guide provides step-by-step instructions for creating a desktop application using .NET and Visual Studio 2019. We'll use Windows Forms to build the application's user interface. By the end of this guide, you'll have a basic understanding of how to design the form, write code, and execute your application.

## Table of Contents

- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Steps](#steps)
  - [Step 1: Create a New Project](#step-1-create-a-new-project)
  - [Step 2: Design the Form](#step-2-design-the-form)
  - [Step 3: Writing Code](#step-3-writing-code)
  - [Step 4: Configure ComboBoxes](#step-4-configure-comboboxes)
  - [Step 5: Build and Run](#step-5-build-and-run)
  - [Step 6: Test the Application](#step-6-test-the-application)
- [Customization and Beyond](#customization-and-beyond)

## Introduction

This guide walks you through the process of creating a desktop application using .NET and Visual Studio 2019. You'll learn how to set up a project, design the application's form, write code for functionality, and run the application to test it.

## Prerequisites

- Visual Studio 2019 (or later)
- Basic familiarity with C# programming

## Getting Started

1. Clone or download this repository to your local machine.
2. Open Visual Studio 2019.

## Steps

### Step 1: Create a New Project

1. Launch Visual Studio 2019.
2. Click on "Create a new project."
3. Search for "Windows Forms App (.NET Framework)."
4. Name your project and choose a location. Click "Create."

### Step 2: Design the Form

1. In the Solution Explorer, right-click on your project.
2. Select "Add" > "Windows Form."
3. Double-click the newly added form (Form1.cs) to open the designer.
4. Drag and drop controls (TextBoxes, ComboBoxes, Button) from the Toolbox onto the form.
5. Customize the control names and properties as needed.

### Step 3: Writing Code

1. Double-click the "Submit" Button to create a Click event handler.
2. Write the C# code to copy a file from the source directory to the target directory.
```csharp
using System;
using System.IO;
using System.Windows.Forms;

namespace FileCopyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
```

### Step 4: Configure ComboBoxes

1. Populate ComboBoxes with values (in the constructor or Load event) to provide user choices.

### Step 5: Build and Run

1. Build the solution (Ctrl + Shift + B).
2. Run the application (F5).

### Step 6: Test the Application

1. Enter source directory, target directory, and file name in the TextBoxes.
2. Choose values from the ComboBoxes.
3. Click "Submit" to copy the file.

## Customization and Beyond

This guide provides a foundation for creating desktop applications. Customize the form design, add more functionality, and explore advanced features in Visual Studio.

Happy coding!



