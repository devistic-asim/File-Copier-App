
namespace File_Copier_App
{
    partial class CopyAllFiles
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.488F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(150, 27);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(289, 26);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Copy All Files from Directory";
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
            // groupBox2
            // 
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(14, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 2);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(121, 116);
            this.txtSourceDirectory.Multiline = true;
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(465, 38);
            this.txtSourceDirectory.TabIndex = 4;
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory.Location = new System.Drawing.Point(121, 183);
            this.txtTargetDirectory.Multiline = true;
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(465, 38);
            this.txtTargetDirectory.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(457, 449);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 45);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(14, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 2);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // CopyAllFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 520);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTargetDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSourceDirectory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Heading);
            this.Name = "CopyAllFiles";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

