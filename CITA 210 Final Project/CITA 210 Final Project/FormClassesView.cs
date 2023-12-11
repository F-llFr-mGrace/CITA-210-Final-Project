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

    // FormClassesView class represents the form for viewing class information
    public partial class FormClassesView : Form
    {
        FormHome FormHomeScript;

        // Constructor for FormClassesView, initializes the form
        public FormClassesView(FormHome initFormHome)
        {
            InitializeComponent();

            // Set the reference to the main form
            FormHomeScript = initFormHome;
        }

        // Event handler for the "View" button click
        private void buttonView_Click(object sender, EventArgs e)
        {
            // Clear the output list box
            listBoxOutput.Items.Clear();

            // Display class information in the output list box
            for (int i = 0; i < FormHomeScript.classId.Count; i++)
            {
                listBoxOutput.Items.Add("# : " + (i + 1) + " || Class ID : " + FormHomeScript.classId[i] + " || Class Name : " + FormHomeScript.className[i]);
            }
        }

        // Event handler for the "Delete" button click
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the output list box
            if (listBoxOutput.SelectedIndex >= 0)
            {
                int selectedIndex = listBoxOutput.SelectedIndex;

                // Check if the selected index is valid
                if (selectedIndex < FormHomeScript.className.Count)
                {
                    // Get the class name to be deleted
                    string classNameToDelete = FormHomeScript.className[selectedIndex];

                    // Iterate through the registrar list and remove matching strings
                    for (int i = 0; i < FormHomeScript.registrar.Count; i++)
                    {
                        FormHomeScript.registrar[i].RemoveAll(s => s == classNameToDelete);
                    }

                    // Remove class information
                    MessageBox.Show("Deleted class ID: " + FormHomeScript.classId[selectedIndex]);
                    FormHomeScript.classId.RemoveAt(selectedIndex);
                    FormHomeScript.className.RemoveAt(selectedIndex);

                    // Update the output list box
                    UpdateOutputListBox();
                }
                else
                {
                    MessageBox.Show("Invalid selection");
                }
            }
            else
            {
                MessageBox.Show("Nothing selected");
            }
        }

        // Helper method to update the output list box
        private void UpdateOutputListBox()
        {
            listBoxOutput.Items.Clear();

            // Display updated information in the output list box
            for (int i = 0; i < FormHomeScript.className.Count; i++)
            {
                listBoxOutput.Items.Add("# : " + (i + 1) + " || Class ID : " + FormHomeScript.classId[i] + " || Class Name : " + FormHomeScript.className[i]);
            }
        }
    }
}
