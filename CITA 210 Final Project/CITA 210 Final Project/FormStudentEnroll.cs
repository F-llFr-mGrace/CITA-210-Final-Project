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

    // FormStudentEnroll class represents the form for enrolling students in classes
    public partial class FormStudentEnroll : Form
    {
        FormHome FormHomeScript;

        // Constructor for FormStudentEnroll, initializes the form
        public FormStudentEnroll(FormHome initFormHome)
        {
            InitializeComponent();

            // Set the reference to the main form
            FormHomeScript = initFormHome;
        }

        // Event handler for the "Refresh" button click
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Refresh the lists of students and classes
            RefreshLists();
        }

        // Method to refresh the lists of students and classes
        private void RefreshLists()
        {
            listBoxStudents.Items.Clear();
            int indexStudent = 0;
            foreach (int Id in FormHomeScript.studentId)
            {
                listBoxStudents.Items.Add("Student ID : " + Id + " || Student Name : " + FormHomeScript.studentName[indexStudent]);
                indexStudent++;
            }

            listBoxClasses.Items.Clear();
            int indexClass = 0;
            foreach (int Id in FormHomeScript.classId)
            {
                listBoxClasses.Items.Add("Class ID : " + Id + " || Class Name : " + FormHomeScript.className[indexClass]);
                indexClass++;
            }
        }

        // Event handler for the "Enroll" button click
        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            // Check if both a student and a class are selected
            if (listBoxStudents.SelectedIndex >= 0 && listBoxClasses.SelectedIndex >= 0)
            {
                // Check if the student is already enrolled in the selected class
                bool isClass = false;

                foreach (string className in FormHomeScript.registrar[listBoxStudents.SelectedIndex])
                {
                    if (className == FormHomeScript.className[listBoxClasses.SelectedIndex])
                    {
                        isClass = true;
                    }
                }

                // If not enrolled, add the class to the student's enrollment list
                if (!isClass)
                {
                    FormHomeScript.registrar[listBoxStudents.SelectedIndex].Add(FormHomeScript.className[listBoxClasses.SelectedIndex]);
                    MessageBox.Show("Enrolled " + FormHomeScript.studentName[listBoxStudents.SelectedIndex] + " into class " + FormHomeScript.className[listBoxClasses.SelectedIndex]);
                }
                else
                {
                    MessageBox.Show("Student is already enrolled in this class");
                }

                // Refresh the lists after enrollment
                RefreshLists();
            }
        }
    }
}
