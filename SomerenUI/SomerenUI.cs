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

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

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
            // clear the listview before filling it
            listViewTeachers.Clear();

            foreach (Teacher teacher in teachers)
            {
                ListViewItem teacherId = new ListViewItem(teacher.teacherId.ToString());
                teacherId.Tag = teacher;
                listViewTeachers.Items.Add(teacherId);


                ListViewItem firstName = new ListViewItem(teacher.firstName);
                firstName.Tag = teacher;  
                listViewTeachers.Items.Add(firstName);

                ListViewItem lastName = new ListViewItem(teacher.lastName);
                lastName.Tag = teacher;
                listViewTeachers.Items.Add(lastName);

                ListViewItem phoneNumber = new ListViewItem(teacher.phoneNumber.ToString());
                phoneNumber.Tag = teacher;
                listViewTeachers.Items.Add(phoneNumber);

                ListViewItem Role = new ListViewItem(teacher.Role);
                Role.Tag = teacher;
                listViewTeachers.Items.Add(Role);

                ListViewItem Age = new ListViewItem(teacher.Age.ToString());
                Age.Tag = teacher;
                listViewTeachers.Items.Add(Age);

                ListViewItem Number = new ListViewItem(teacher.Number.ToString());
                Number.Tag = teacher;
                listViewTeachers.Items.Add(Number);
            }
        }


        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();

            foreach (Student student in students)
            {
                ListViewItem id = new ListViewItem(student.Id.ToString());
                id.Tag = student;
                listViewStudents.Items.Add(id);

                ListViewItem firstName = new ListViewItem(student.FirstName);
                firstName.Tag = student;
                listViewStudents.Items.Add(firstName);

                ListViewItem lastName = new ListViewItem(student.LastName);
                lastName.Tag = student;
                listViewStudents.Items.Add(lastName);

                ListViewItem number = new ListViewItem(student.Number.ToString());
                number.Tag = student;
                listViewStudents.Items.Add(number);
            }
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
    }
}