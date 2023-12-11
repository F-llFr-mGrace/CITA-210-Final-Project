namespace CITA_210_Final_Project
{
    partial class FormStudentView
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
            listBoxOutput = new ListBox();
            buttonView = new Button();
            numericUpDownStudentIndex = new NumericUpDown();
            numericUpDownEnrollment = new NumericUpDown();
            buttonDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStudentIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnrollment).BeginInit();
            SuspendLayout();
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(12, 12);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(517, 304);
            listBoxOutput.TabIndex = 0;
            // 
            // buttonView
            // 
            buttonView.Location = new Point(12, 322);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(517, 78);
            buttonView.TabIndex = 1;
            buttonView.Text = "View All (Refresh)";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // numericUpDownStudentIndex
            // 
            numericUpDownStudentIndex.Location = new Point(205, 406);
            numericUpDownStudentIndex.Name = "numericUpDownStudentIndex";
            numericUpDownStudentIndex.Size = new Size(170, 27);
            numericUpDownStudentIndex.TabIndex = 2;
            // 
            // numericUpDownEnrollment
            // 
            numericUpDownEnrollment.Location = new Point(205, 439);
            numericUpDownEnrollment.Name = "numericUpDownEnrollment";
            numericUpDownEnrollment.Size = new Size(170, 27);
            numericUpDownEnrollment.TabIndex = 3;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(463, 406);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(66, 60);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 408);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 5;
            label1.Text = "Student Index";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 441);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 6;
            label2.Text = "Enrollment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 478);
            label3.Name = "label3";
            label3.Size = new Size(363, 20);
            label3.TabIndex = 7;
            label3.Text = "If only Student is above 0, the student will be deleted.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 507);
            label4.Name = "label4";
            label4.Size = new Size(316, 20);
            label4.TabIndex = 8;
            label4.Text = "If both fields are above 0 then the class will be";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 527);
            label5.Name = "label5";
            label5.Size = new Size(193, 20);
            label5.TabIndex = 9;
            label5.Text = "deleted but not the student.";
            // 
            // FormStudentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 556);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(numericUpDownEnrollment);
            Controls.Add(numericUpDownStudentIndex);
            Controls.Add(buttonView);
            Controls.Add(listBoxOutput);
            Name = "FormStudentView";
            Text = "Student View";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStudentIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnrollment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxOutput;
        private Button buttonView;
        private NumericUpDown numericUpDownStudentIndex;
        private NumericUpDown numericUpDownEnrollment;
        private Button buttonDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}