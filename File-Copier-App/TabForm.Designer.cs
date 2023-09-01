
namespace File_Copier_App
{
    partial class TabForm
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
            this.Heading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit_1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxOverride_1 = new System.Windows.Forms.CheckBox();
            this.txtTargetDirectory_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSourceDirectory_1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtFileName_2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxOverride_2 = new System.Windows.Forms.CheckBox();
            this.txtTargetDirectory_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSourceDirectory_2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit_2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.488F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(150, 27);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(258, 26);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Copy Files from Directory";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(142, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 2);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnSubmit_1
            // 
            this.btnSubmit_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit_1.Location = new System.Drawing.Point(423, 341);
            this.btnSubmit_1.Name = "btnSubmit_1";
            this.btnSubmit_1.Size = new System.Drawing.Size(131, 45);
            this.btnSubmit_1.TabIndex = 8;
            this.btnSubmit_1.Text = "Submit";
            this.btnSubmit_1.UseVisualStyleBackColor = true;
            this.btnSubmit_1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 431);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.checkBoxOverride_1);
            this.tabPage1.Controls.Add(this.txtTargetDirectory_1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.txtSourceDirectory_1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSubmit_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Files Copier";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Override:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxOverride_1
            // 
            this.checkBoxOverride_1.Checked = true;
            this.checkBoxOverride_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOverride_1.Location = new System.Drawing.Point(117, 148);
            this.checkBoxOverride_1.Name = "checkBoxOverride_1";
            this.checkBoxOverride_1.Size = new System.Drawing.Size(309, 40);
            this.checkBoxOverride_1.TabIndex = 17;
            this.checkBoxOverride_1.Text = "(check the box if you want to override the files. Othervise a copy of file will b" +
    "e save)";
            this.checkBoxOverride_1.UseVisualStyleBackColor = true;
            // 
            // txtTargetDirectory_1
            // 
            this.txtTargetDirectory_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory_1.Location = new System.Drawing.Point(117, 84);
            this.txtTargetDirectory_1.Multiline = true;
            this.txtTargetDirectory_1.Name = "txtTargetDirectory_1";
            this.txtTargetDirectory_1.Size = new System.Drawing.Size(435, 38);
            this.txtTargetDirectory_1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Target:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(10, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 2);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // txtSourceDirectory_1
            // 
            this.txtSourceDirectory_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceDirectory_1.Location = new System.Drawing.Point(117, 17);
            this.txtSourceDirectory_1.Multiline = true;
            this.txtSourceDirectory_1.Name = "txtSourceDirectory_1";
            this.txtSourceDirectory_1.Size = new System.Drawing.Size(435, 38);
            this.txtSourceDirectory_1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(10, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 2);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Source:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtFileName_2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.checkBoxOverride_2);
            this.tabPage2.Controls.Add(this.txtTargetDirectory_2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.txtSourceDirectory_2);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnSubmit_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(569, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Single File Copier";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtFileName_2
            // 
            this.txtFileName_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName_2.Location = new System.Drawing.Point(119, 149);
            this.txtFileName_2.Multiline = true;
            this.txtFileName_2.Name = "txtFileName_2";
            this.txtFileName_2.Size = new System.Drawing.Size(435, 38);
            this.txtFileName_2.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "File Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Location = new System.Drawing.Point(12, 201);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(544, 2);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Override:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxOverride_2
            // 
            this.checkBoxOverride_2.Checked = true;
            this.checkBoxOverride_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOverride_2.Location = new System.Drawing.Point(117, 209);
            this.checkBoxOverride_2.Name = "checkBoxOverride_2";
            this.checkBoxOverride_2.Size = new System.Drawing.Size(309, 40);
            this.checkBoxOverride_2.TabIndex = 26;
            this.checkBoxOverride_2.Text = "(check the box if you want to override the files. Othervise a copy of file will b" +
    "e save)";
            this.checkBoxOverride_2.UseVisualStyleBackColor = true;
            // 
            // txtTargetDirectory_2
            // 
            this.txtTargetDirectory_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory_2.Location = new System.Drawing.Point(119, 84);
            this.txtTargetDirectory_2.Multiline = true;
            this.txtTargetDirectory_2.Name = "txtTargetDirectory_2";
            this.txtTargetDirectory_2.Size = new System.Drawing.Size(435, 38);
            this.txtTargetDirectory_2.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Target:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(12, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 2);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // txtSourceDirectory_2
            // 
            this.txtSourceDirectory_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceDirectory_2.Location = new System.Drawing.Point(119, 17);
            this.txtSourceDirectory_2.Multiline = true;
            this.txtSourceDirectory_2.Name = "txtSourceDirectory_2";
            this.txtSourceDirectory_2.Size = new System.Drawing.Size(435, 38);
            this.txtSourceDirectory_2.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(12, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(544, 2);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Source:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit_2
            // 
            this.btnSubmit_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit_2.Location = new System.Drawing.Point(425, 341);
            this.btnSubmit_2.Name = "btnSubmit_2";
            this.btnSubmit_2.Size = new System.Drawing.Size(131, 45);
            this.btnSubmit_2.TabIndex = 19;
            this.btnSubmit_2.Text = "Submit";
            this.btnSubmit_2.UseVisualStyleBackColor = true;
            this.btnSubmit_2.Click += new System.EventHandler(this.btnSubmit_2_Click);
            // 
            // TabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Heading);
            this.Name = "TabForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit_1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxOverride_1;
        private System.Windows.Forms.TextBox txtTargetDirectory_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSourceDirectory_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxOverride_2;
        private System.Windows.Forms.TextBox txtTargetDirectory_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSourceDirectory_2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit_2;
    }
}

