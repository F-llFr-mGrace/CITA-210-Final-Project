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
    public partial class FormClassesAdd : Form
    {
        FormHome FormHomeScript;

        public FormClassesAdd(FormHome initFormHome)
        {
            InitializeComponent();

            FormHomeScript = initFormHome;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormHomeScript.classId.Add(FormHomeScript.classIdRef);
            FormHomeScript.classIdRef++;

            FormHomeScript.className.Add(textBoxInput.Text);
        }
    }
}
