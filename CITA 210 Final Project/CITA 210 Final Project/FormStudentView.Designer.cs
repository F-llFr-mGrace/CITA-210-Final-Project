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
            buttonDelete = new Button();
            buttonView = new Button();
            SuspendLayout();
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(12, 12);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(348, 304);
            listBoxOutput.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(286, 322);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(74, 78);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonView
            // 
            buttonView.Location = new Point(12, 322);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(268, 78);
            buttonView.TabIndex = 1;
            buttonView.Text = "View All";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // FormStudentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonView);
            Controls.Add(buttonDelete);
            Controls.Add(listBoxOutput);
            Name = "FormStudentView";
            Text = "Student View";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxOutput;
        private Button buttonDelete;
        private Button buttonView;
    }
}