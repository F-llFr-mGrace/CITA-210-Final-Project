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
    public partial class FormStudentEnroll : Form
    {
        FormHome FormHomeScript;

        public FormStudentEnroll(FormHome initFormHome)
        {
            InitializeComponent();

            FormHomeScript = initFormHome;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshLists();
        }

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

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedIndex >= 0 && listBoxClasses.SelectedIndex >= 0)
            {
                bool isClass = false;

                foreach (string className in FormHomeScript.registrar[listBoxStudents.SelectedIndex])
                {
                    if (className == listBoxClasses.SelectedItem)
                    {
                        isClass = true;
                    }
                }

                if (!isClass)
                {
                    FormHomeScript.registrar[listBoxStudents.SelectedIndex].Add(FormHomeScript.className[listBoxClasses.SelectedIndex]);
                }

                else
                {
                    MessageBox.Show("Student is already enrolled in this class");
                }

                RefreshLists();
            }
        }
    }
}
