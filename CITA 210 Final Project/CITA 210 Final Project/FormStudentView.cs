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
    public partial class FormStudentView : Form
    {
        FormHome FormHomeScript;

        public FormStudentView(FormHome initFormHome)
        {
            InitializeComponent();

            FormHomeScript = initFormHome;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FormHomeScript.studentId.Count; i++)
            {
                listBoxOutput.Items.Add("Student ID : " + FormHomeScript.studentId[i] + " || Student Name : " + FormHomeScript.studentName[i]);
            }
        }
    }
}
