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
    public partial class FormStudentSearch : Form
    {
        FormHome FormHomeScript;

        public FormStudentSearch(FormHome initFormHome)
        {
            InitializeComponent();

            FormHomeScript = initFormHome;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            foreach (int Id in FormHomeScript.studentId)
            {
                if (Id == (int)numericUpDown1.Value)
                {
                    textBoxOutput.Text = ("Student ID : " + Id + " || Student Name : " + FormHomeScript.studentName[(Id - 1)]).ToString();
                }
            }
        }
    }
}
