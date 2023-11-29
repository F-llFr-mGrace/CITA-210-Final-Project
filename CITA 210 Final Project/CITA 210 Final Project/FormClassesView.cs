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
    public partial class FormClassesView : Form
    {
        FormHome FormHomeScript;

        public FormClassesView(FormHome initFormHome)
        {
            InitializeComponent();

            FormHomeScript = initFormHome;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            for (int i = 0; i < FormHomeScript.classId.Count; i++)
            {
                listBoxOutput.Items.Add("# : " + (i + 1) + " || Class ID : " + FormHomeScript.classId[i] + " || Class Name : " + FormHomeScript.className[i]);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
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
