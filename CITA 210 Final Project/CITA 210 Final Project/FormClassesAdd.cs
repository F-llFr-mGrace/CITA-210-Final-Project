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

    // FormClassesAdd class represents the form for adding class information
    public partial class FormClassesAdd : Form
    {
        FormHome FormHomeScript;

        // Constructor for FormClassesAdd, initializes the form
        public FormClassesAdd(FormHome initFormHome)
        {
            InitializeComponent();

            // Set the reference to the main form
            FormHomeScript = initFormHome;
        }

        // Event handler for the "Add" button click
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Add class information to the main form's lists
            FormHomeScript.classId.Add(FormHomeScript.classIdRef);
            MessageBox.Show("Successfully added class! ID number: " + FormHomeScript.classIdRef);
            FormHomeScript.classIdRef++;

            FormHomeScript.className.Add(textBoxInput.Text);
        }
    }
}
