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
    public partial class FormStudentAdd : Form
    {
        FormHome FormHomeScript;

        public FormStudentAdd(FormHome initFormHome)
        {
            InitializeComponent();

            FormHomeScript = initFormHome;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormHomeScript.studentId.Add(FormHomeScript.studentIdRef);
            FormHomeScript.studentIdRef++;

            FormHomeScript.studentName.Add(textBoxInput.Text);

            FormHomeScript.registrar.Add(new List<string>());
        }
    }
}
