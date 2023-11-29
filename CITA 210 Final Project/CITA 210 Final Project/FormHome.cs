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

            varFormStudentAdd = new FormStudentAdd(this);
            varFormStudentView = new FormStudentView(this);
            varFormStudentSearch = new FormStudentSearch(this);
            varFormStudentEnroll = new FormStudentEnroll(this);
            varFormClassesAdd = new FormClassesAdd(this);
            varFormClassesView = new FormClassesView(this);

            studentId.Add(1);
            studentName.Add("Grace");

            studentId.Add(2);
            studentName.Add("Aidan");

            studentId.Add(3);
            studentName.Add("Matt");
        }

        private void FormStudentAdd_Click(object sender, EventArgs e)
        {
            varFormStudentAdd.Show();
        }

        private void FormStudentView_Click(object sender, EventArgs e)
        {
            varFormStudentView.Show();
        }

        private void FormStudentSearch_Click(object sender, EventArgs e)
        {
            varFormStudentSearch.Show();
        }

        private void FormStudentEnroll_Click(object sender, EventArgs e)
        {
            varFormStudentEnroll.Show();
        }

        private void FormClassesAdd_Click(object sender, EventArgs e)
        {
            varFormClassesAdd.Show();
        }

        private void FormClassesView_Click(object sender, EventArgs e)
        {
            varFormClassesView.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int studentIdRef = 4;
        public List<int> studentId = new List<int>();
        public List<string> studentName = new List<string>();

        public int ClassIdRef = 4;
        public List<int> ClassId = new List<int>();
        public List<string> ClassName = new List<string>();
    }
}
