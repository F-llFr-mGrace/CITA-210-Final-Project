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

    // FormStudentSearch class represents the form for searching and displaying student information
    public partial class FormStudentSearch : Form
    {
        FormHome FormHomeScript;
        bool isFound = false;

        // Constructor for FormStudentSearch, initializes the form
        public FormStudentSearch(FormHome initFormHome)
        {
            InitializeComponent();

            // Set the reference to the main form
            FormHomeScript = initFormHome;
        }

        // Event handler for the "Search" button click
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Counts for every int in FormHomeScript.studentId
            int index = 0;
            // Iterate through each student ID to find a match
            foreach (int Id in FormHomeScript.studentId)
            {
                // Check if the current student ID matches the value in the numeric up-down control
                if (Id == (int)numericUpDown1.Value)
                {
                    // Display the student information in the text box
                    textBoxOutput.Text = ("Student ID : " + Id + " || Student Name : " + FormHomeScript.studentName[(index)]).ToString();
                    isFound = true;
                }
                index++;
            }
            if (!isFound)
            {
                MessageBox.Show("Invalid index");
                isFound = false;
            }
        }
    }
}
