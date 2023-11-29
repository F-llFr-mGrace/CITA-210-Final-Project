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
     * Programmed by Grace Fowler
     */

    // FormStudentView class represents the form for viewing student information
    public partial class FormStudentView : Form
    {
        FormHome FormHomeScript;

        // Constructor for FormStudentView, initializes the form
        public FormStudentView(FormHome initFormHome)
        {
            InitializeComponent();

            FormHomeScript = initFormHome;
        }

        // Event handler for the "Delete" button click
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check and handle various conditions for deleting student information
            if (IsStudentIndexValid() && (int)numericUpDownEnrollment.Value <= 0)
            {
                int studentIndex = (int)numericUpDownStudentIndex.Value;

                if (IsStudentIndexInRange(studentIndex))
                {
                    // Remove student information
                    FormHomeScript.studentId.RemoveAt(studentIndex - 1);
                    FormHomeScript.studentName.RemoveAt(studentIndex - 1);

                    // Remove the entire registrar class list for the deleted student
                    FormHomeScript.registrar.RemoveAt(studentIndex - 1);
                }
            }
            else if (IsStudentIndexValid() && (int)numericUpDownEnrollment.Value > 0)
            {
                int studentIndex = (int)numericUpDownStudentIndex.Value;

                if (IsStudentIndexInRange(studentIndex) && FormHomeScript.registrar.Count > studentIndex - 1)
                {
                    int enrollmentIndex = (int)numericUpDownEnrollment.Value;

                    if (IsEnrollmentIndexInRange(enrollmentIndex, studentIndex))
                    {
                        // Remove enrollment information
                        FormHomeScript.registrar[studentIndex - 1].RemoveAt(enrollmentIndex - 1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }
        }


        // Event handler for the "View" button click
        private void buttonView_Click(object sender, EventArgs e)
        {
            // Clear the output list box
            listBoxOutput.Items.Clear();

            // Display student information in the output list box
            for (int i = 0; i < FormHomeScript.studentId.Count; i++)
            {
                int studentIndex = i + 1;
                listBoxOutput.Items.Add("# : " + studentIndex + " || Student ID : " + FormHomeScript.studentId[i] + " || Student Name : " + FormHomeScript.studentName[i]);

                if (IsStudentIndexInRange(studentIndex) && FormHomeScript.registrar.Count > studentIndex - 1)
                {
                    int enrollmentCount = FormHomeScript.registrar[studentIndex - 1].Count;

                    // Check if registrar has enough elements for the current studentIndex
                    if (FormHomeScript.registrar.Count > studentIndex - 1)
                    {
                        for (int j = 0; j < enrollmentCount; j++)
                        {
                            // Use j + 1 as enrollmentIndex
                            int enrollmentIndex = j + 1;

                            // Check if registrar has enough elements for the current index
                            if (FormHomeScript.registrar[studentIndex - 1].Count > j)
                            {
                                listBoxOutput.Items.Add("# : " + enrollmentIndex + " || Class name : " + FormHomeScript.registrar[studentIndex - 1][j].ToString());
                            }
                            else
                            {
                                // Handle the case where registrar doesn't have enough elements for the current enrollmentIndex
                                listBoxOutput.Items.Add("# : " + enrollmentIndex + " || Data mismatch: Enrollment data not available");
                            }
                        }
                    }
                    else
                    {
                        // Handle the case where registrar doesn't have enough elements for the current studentIndex
                        listBoxOutput.Items.Add("# : Data mismatch: Student enrollment data not available");
                    }
                }
            }
        }

        // Check if the student index is within a valid range
        private bool IsStudentIndexInRange(int studentIndex)
        {
            return studentIndex >= 1 && studentIndex <= FormHomeScript.studentId.Count;
        }

        // Check if the student index is valid (greater than 0)
        private bool IsStudentIndexValid()
        {
            return (int)numericUpDownStudentIndex.Value > 0;
        }

        // Check if the enrollment index is within a valid range for a given student
        private bool IsEnrollmentIndexInRange(int enrollmentIndex, int studentIndex)
        {
            return enrollmentIndex <= FormHomeScript.registrar[studentIndex - 1].Count;
        }
    }
}
