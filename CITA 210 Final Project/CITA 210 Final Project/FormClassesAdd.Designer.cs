﻿namespace CITA_210_Final_Project
{
    partial class FormClassesAdd
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
            textBoxInput = new TextBox();
            buttonAdd = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 12);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(435, 27);
            textBoxInput.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(453, 11);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 42);
            label1.Name = "label1";
            label1.Size = new Size(303, 20);
            label1.TabIndex = 2;
            label1.Text = "Department then number example: CITA 212";
            // 
            // FormClassesAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 76);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxInput);
            Name = "FormClassesAdd";
            Text = "Classes Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonAdd;
        private Label label1;
    }
}