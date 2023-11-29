using System.Collections.Generic;

namespace CITA_210_Final_Project
{
    public partial class FormHome : Form
    {
        FormStudentAdd varFormStudentAdd;
        FormStudentView varFormStudentView;
        FormStudentSearch varFormStudentSearch;
        FormStudentEnroll varFormStudentEnroll;
        FormClassesAdd varFormClassesAdd;
        FormClassesView varFormClassesView;

        public FormHome()
        {
            InitializeComponent();

            studentId.Add(1);
            studentName.Add("Grace");
            registrar.Add(new List<string>());

            studentId.Add(2);
            studentName.Add("Aidan");
            registrar.Add(new List<string>());

            studentId.Add(3);
            studentName.Add("Matt");
            registrar.Add(new List<string>());
        }

        private void FormStudentAdd_Click(object sender, EventArgs e)
        {
            varFormStudentAdd = new FormStudentAdd(this);
            varFormStudentAdd.Show();
        }

        private void FormStudentView_Click(object sender, EventArgs e)
        {
            varFormStudentView = new FormStudentView(this);
            varFormStudentView.Show();
        }

        private void FormStudentSearch_Click(object sender, EventArgs e)
        {
            varFormStudentSearch = new FormStudentSearch(this);
            varFormStudentSearch.Show();
        }

        private void FormStudentEnroll_Click(object sender, EventArgs e)
        {
            varFormStudentEnroll = new FormStudentEnroll(this);
            varFormStudentEnroll.Show();
        }

        private void FormClassesAdd_Click(object sender, EventArgs e)
        {
            varFormClassesAdd = new FormClassesAdd(this);
            varFormClassesAdd.Show();
        }

        private void FormClassesView_Click(object sender, EventArgs e)
        {
            varFormClassesView = new FormClassesView(this);
            varFormClassesView.Show();
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int studentIdRef = 4;
        public List<int> studentId = new List<int>();
        public List<string> studentName = new List<string>();

        public int classIdRef = 1;
        public List<int> classId = new List<int>();
        public List<string> className = new List<string>();

        public List<List<string>> registrar = new List<List<string>>();
    }
}
