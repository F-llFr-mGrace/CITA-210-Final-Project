namespace CITA_210_Final_Project
{
    partial class FormClassesView
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
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(12, 12);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(332, 424);
            listBoxOutput.TabIndex = 0;
            // 
            // buttonView
            // 
            buttonView.Location = new Point(12, 442);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(226, 89);
            buttonView.TabIndex = 1;
            buttonView.Text = "View All (Refresh)";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(244, 442);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(98, 89);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormClassesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 543);
            Controls.Add(buttonDelete);
            Controls.Add(buttonView);
            Controls.Add(listBoxOutput);
            Name = "FormClassesView";
            Text = "Classes View";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxOutput;
        private Button buttonView;
        private Button buttonDelete;
    }
}