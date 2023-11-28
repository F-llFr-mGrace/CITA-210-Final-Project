using System.Collections.Generic;

namespace CITA_210_Final_Project
{
    // The FormHome class represents the main form of the application
    public partial class FormHome : Form
    {
        // Declare instances of other forms to be used in the application
        FormStudentAdd varFormStudentAdd = new FormStudentAdd();
        FormStudentView varFormStudentView = new FormStudentView();
        FormStudentSearch varFormStudentSearch = new FormStudentSearch();
        FormStudentEnroll varFormStudentEnroll = new FormStudentEnroll();
        FormClassesAdd varFormClassesAdd = new FormClassesAdd();
        FormClassesView varFormClassesView = new FormClassesView();

        // Constructor for the FormHome class
        public FormHome()
        {
            InitializeComponent();

            studentId.Add(1);
            studentName.Add("Grace");

            studentId.Add(2);
            studentName.Add("Aidan");

            studentId.Add(3);
            studentName.Add("Matt");
        }

        // Event handler for the "Add Student" button click
        private void FormStudentAdd_Click(object sender, EventArgs e)
        {
            // Show the FormStudentAdd when the button is clicked
            varFormStudentAdd.Show();
        }

        // Event handler for the "View Student" button click
        private void FormStudentView_Click(object sender, EventArgs e)
        {
            // Show the FormStudentView when the button is clicked
            varFormStudentView.Show();
        }

        // Event handler for the "Search Student" button click
        private void FormStudentSearch_Click(object sender, EventArgs e)
        {
            // Show the FormStudentSearch when the button is clicked
            varFormStudentSearch.Show();
        }

        // Event handler for the "Enroll Student" button click
        private void FormStudentEnroll_Click(object sender, EventArgs e)
        {
            // Show the FormStudentEnroll when the button is clicked
            varFormStudentEnroll.Show();
        }

        // Event handler for the "Add Classes" button click
        private void FormClassesAdd_Click(object sender, EventArgs e)
        {
            // Show the FormClassesAdd when the button is clicked
            varFormClassesAdd.Show();
        }

        // Event handler for the "View Classes" button click
        private void FormClassesView_Click(object sender, EventArgs e)
        {
            // Show the FormClassesView when the button is clicked
            varFormClassesView.Show();
        }
        //FormHome varFormHome = new FormHome();

        public int studentIdRef = 4;
        public List<int> studentId = new List<int>();
        public List<string> studentName = new List<string>();

        public int ClassIdRef = 4;
        public List<int> ClassId = new List<int>();
        public List<string> ClassName = new List<string>();

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}
