using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlKassa.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlKassa.Hide();
            pnlTeachers.Hide();
            

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowTeachersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlKassa.Hide();
            pnlStudents.Hide();

            // show Teachers
            pnlTeachers.Show();

            try
            {
                // get and display all teachers
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }
        private List<Teacher> GetTeachers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;        
        }

        private void DisplayTeachers(List<Teacher> teachers)
        {
            teacherDataGridView.DataSource = teachers;
        }


        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            studentDataGridView.DataSource = students;
        }



        //Kassa / Drinks
        private void ShowKassaPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlTeachers.Hide();
            pnlStudents.Hide();

            // show Kassa
            pnlKassa.Show();

            try
            {
                // get and display all drinks
                List<Drinks> drinks = GetDrinks();
                DisplayDrinks(drinks);

                // get and display all students
                List<Student> students = GetStudents();
                DisplayDrinksStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }

        private List<Drinks> GetDrinks()
        {
            DrinksService drinksService = new DrinksService();
            List<Drinks> drinks = drinksService.GetDrinks();
            return drinks;
        }

        private void DisplayDrinksStudents(List<Student> students)
        {
            studentDrinksDataGrid.DataSource = students;
        }

        private void DisplayDrinks(List<Drinks> drinks)
        {
            drinksDataGridView.DataSource = drinks;
        }










        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void houbeblaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lecturersButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnlStudents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bardienstToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowKassaPanel();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }
    }
}