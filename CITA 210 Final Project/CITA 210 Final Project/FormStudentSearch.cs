﻿using System;
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
            //textBoxOutput.Text = FormHomeScript.studentId[(int)numericUpDown1.Value].ToString;
        }
    }
}
