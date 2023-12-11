using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CITA_210_Final_Project
{
    /*
     * Comments provided by ChatGPT
     * Programmed by Group 2
     */

    // FormStudentAdd class represents the form for adding new student information
    public partial class FormStudentAdd : Form
    {
        FormHome FormHomeScript;

        // Constructor for FormStudentAdd, initializes the form
        public FormStudentAdd(FormHome initFormHome)
        {
            InitializeComponent();

            // Set the reference to the main form
            FormHomeScript = initFormHome;
        }

        // Event handler for the "Add" button click
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Add new student information to the main form's lists
            FormHomeScript.studentId.Add(FormHomeScript.studentIdRef);

            FormHomeScript.studentName.Add(textBoxInput.Text);

            // Add an empty list for the student's classes
            FormHomeScript.registrar.Add(new List<string>());
            MessageBox.Show("Successfully added student! ID number: " + FormHomeScript.studentIdRef);
            FormHomeScript.studentIdRef++;
        }
    }
}
