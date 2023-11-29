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
            MessageBox.Show(numericUpDownStudentIndex.Value + " | RAW | " + numericUpDownEnrollment.Value);
            MessageBox.Show((int)numericUpDownStudentIndex.Value + " | To int | " + (int)numericUpDownEnrollment.Value);

            if ((int)numericUpDownStudentIndex.Value > 0 && (int)numericUpDownEnrollment.Value <= 0)
            {
                MessageBox.Show(((int)numericUpDownStudentIndex.Value).ToString());
                if ((int)numericUpDownStudentIndex.Value <= FormHomeScript.studentId.Count)
                {
                    if (FormHomeScript.studentId[(int)numericUpDownStudentIndex.Value - 1] > 0)
                    {
                        MessageBox.Show("delete state 1");
                        FormHomeScript.studentId.RemoveAt((int)numericUpDownStudentIndex.Value - 1);
                        FormHomeScript.studentName.RemoveAt((int)numericUpDownStudentIndex.Value - 1);
                    }
                }
            }
            else if ((int)numericUpDownStudentIndex.Value > 0 && (int)numericUpDownEnrollment.Value > 0)
            {
                if (FormHomeScript.registrar[(int)numericUpDownStudentIndex.Value - 1] == null)
                {
                    FormHomeScript.registrar[(int)numericUpDownStudentIndex.Value - 1].RemoveAt((int)numericUpDownEnrollment.Value - 1);
                }
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            int studentIndex = 1;
            int enrollmentIndex = 1;
            for (int i = 0; i < FormHomeScript.studentId.Count; i++)
            {
                listBoxOutput.Items.Add("# : " + studentIndex + " || Student ID : " + FormHomeScript.studentId[i] + " || Student Name : " + FormHomeScript.studentName[i]);
                studentIndex++;

                if ((int)numericUpDownStudentIndex.Value > 0 && (int)numericUpDownEnrollment.Value > 0)
                {
                    if (FormHomeScript.registrar[(int)numericUpDownStudentIndex.Value - 1] != null)
                    {
                        for (int j = 0; j < FormHomeScript.registrar[(int)numericUpDownEnrollment.Value].Count; j++)
                        {
                            listBoxOutput.Items.Add("# : " + enrollmentIndex + " || Student ID : " + FormHomeScript.classId[i] + " || Student Name : " + FormHomeScript.className[i]);
                            enrollmentIndex++;
                        }
                    }
                }
            }
        }
    }
}
