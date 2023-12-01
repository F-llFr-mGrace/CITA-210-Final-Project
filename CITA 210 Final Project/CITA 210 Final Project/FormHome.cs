using System.Collections.Generic;

namespace CITA_210_Final_Project
{
    /*
     * Comments provided by ChatGPT
     * Programmed by Grace Fowler
     */

    // FormHome class represents the main form of the application
    public partial class FormHome : Form
    {
        // Instances of other forms
        FormStudentAdd varFormStudentAdd;
        FormStudentView varFormStudentView;
        FormStudentSearch varFormStudentSearch;
        FormStudentEnroll varFormStudentEnroll;
        FormClassesAdd varFormClassesAdd;
        FormClassesView varFormClassesView;

        // Lists to store student and class information
        public List<int> studentId = new List<int>();
        public List<string> studentName = new List<string>();
        public List<int> classId = new List<int>();
        public List<string> className = new List<string>();
        public List<List<string>> registrar = new List<List<string>>();

        // Constructor initializes the main form and adds sample data
        public FormHome()
        {
            InitializeComponent();

            // Sample data for students and their enrolled classes
            studentId.Add(1);
            studentName.Add("Grace");
<<<<<<< HEAD
            registrar.Add(new List<string>() {"CITA 210"});
=======
            registrar.Add(new List<string>() { "CITA 210" });
>>>>>>> In-progress

            studentId.Add(2);
            studentName.Add("Aidan");
            registrar.Add(new List<string>() { "CITA 210" });

            studentId.Add(3);
            studentName.Add("Matt");
<<<<<<< HEAD
            registrar.Add(new List<string>());
=======
            registrar.Add(new List<string>() { "CITA 210" });
>>>>>>> In-progress

            classId.Add(1);
            className.Add("CITA 210");

            classId.Add(2);
            className.Add("CITA 200");

            classId.Add(3);
            className.Add("CITA 212");
        }

        // Event handler for opening the FormStudentAdd
        private void FormStudentAdd_Click(object sender, EventArgs e)
        {
            varFormStudentAdd = new FormStudentAdd(this);
            varFormStudentAdd.Show();
        }

        // Event handler for opening the FormStudentView
        private void FormStudentView_Click(object sender, EventArgs e)
        {
            varFormStudentView = new FormStudentView(this);
            varFormStudentView.Show();
        }

        // Event handler for opening the FormStudentSearch
        private void FormStudentSearch_Click(object sender, EventArgs e)
        {
            varFormStudentSearch = new FormStudentSearch(this);
            varFormStudentSearch.Show();
        }

        // Event handler for opening the FormStudentEnroll
        private void FormStudentEnroll_Click(object sender, EventArgs e)
        {
            varFormStudentEnroll = new FormStudentEnroll(this);
            varFormStudentEnroll.Show();
        }

        // Event handler for opening the FormClassesAdd
        private void FormClassesAdd_Click(object sender, EventArgs e)
        {
            varFormClassesAdd = new FormClassesAdd(this);
            varFormClassesAdd.Show();
        }

        // Event handler for opening the FormClassesView
        private void FormClassesView_Click(object sender, EventArgs e)
        {
            varFormClassesView = new FormClassesView(this);
            varFormClassesView.Show();
        }

        // Event handler for the Exit button to close the application
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Reference for the next student ID
        public int studentIdRef = 4;

        // Reference for the next class ID
        public int classIdRef = 4;
    }
}
