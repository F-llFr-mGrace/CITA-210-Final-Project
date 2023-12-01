namespace CITA_210_Final_Project
{
    partial class FormStudentEnroll
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
            listBoxStudents = new ListBox();
            listBoxClasses = new ListBox();
            buttonEnroll = new Button();
            buttonRefresh = new Button();
            SuspendLayout();
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.Location = new Point(12, 12);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(309, 424);
            listBoxStudents.TabIndex = 0;
            // 
            // listBoxClasses
            // 
            listBoxClasses.FormattingEnabled = true;
            listBoxClasses.Location = new Point(548, 12);
            listBoxClasses.Name = "listBoxClasses";
            listBoxClasses.Size = new Size(309, 424);
            listBoxClasses.TabIndex = 1;
            // 
            // buttonEnroll
            // 
            buttonEnroll.Location = new Point(327, 84);
            buttonEnroll.Name = "buttonEnroll";
            buttonEnroll.Size = new Size(215, 66);
            buttonEnroll.TabIndex = 3;
            buttonEnroll.Text = "Enroll";
            buttonEnroll.UseVisualStyleBackColor = true;
            buttonEnroll.Click += buttonEnroll_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(327, 12);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(215, 66);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // FormStudentEnroll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 447);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonEnroll);
            Controls.Add(listBoxClasses);
            Controls.Add(listBoxStudents);
            Name = "FormStudentEnroll";
            Text = "Student Enroll";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxStudents;
        private ListBox listBoxClasses;
        private Button buttonEnroll;
        private Button buttonRefresh;
    }
}