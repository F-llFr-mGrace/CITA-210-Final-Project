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
    public partial class FormStudentEnroll : Form
    {
        FormHome FormHomeScript;

        public FormStudentEnroll(FormHome initFormHome)
        {
            InitializeComponent();

            FormHomeScript = initFormHome;
        }
    }
}
