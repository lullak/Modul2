﻿namespace FormsFile2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            lstFiles = new ListBox();
            cmdVisaFiler = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 35);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Filkatalog";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.Location = new Point(123, 130);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(583, 204);
            lstFiles.TabIndex = 2;
            // 
            // cmdVisaFiler
            // 
            cmdVisaFiler.Location = new Point(121, 352);
            cmdVisaFiler.Name = "cmdVisaFiler";
            cmdVisaFiler.Size = new Size(129, 51);
            cmdVisaFiler.TabIndex = 3;
            cmdVisaFiler.Text = "Visa filer";
            cmdVisaFiler.UseVisualStyleBackColor = true;
            cmdVisaFiler.Click += cmdVisaFiler_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdVisaFiler);
            Controls.Add(lstFiles);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox lstFiles;
        private Button cmdVisaFiler;
    }
}
