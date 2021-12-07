using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class Form1 : Form
    {
        List<STUDENT>students = new List<STUDENT>();
        List<TEACHER> teachers = new List<TEACHER>();
        List<ADMIN> admins = new List<ADMIN>();
        public Form1()
        {
            InitializeComponent();
        }

        private void clearStudentButton_Click(object sender, EventArgs e)
        {
            studentIdTextBox.Text = "";
            studentNameTextBox.Text = "";
            studentSemesterTextBox.Text = "";
            studentDepartmentTextbox.Text = "";
            
        }

        private void clearTeacherButton_Click(object sender, EventArgs e)
        {
            teacherDepartmentTextBox.Text = "";
            teacherDesignationTextBox.Text = "";
            teacherIdTextBox.Text = "";
            teacherNameTextBox.Text = "";
            teacherSalaryTextBox.Text = "";
        }

        private void clearAdminButon_Click(object sender, EventArgs e)
        {
            adminDesignationTextBox.Text = "";
            adminIdTextBox.Text = "";
            adminNameTextBox.Text = "";
            adminSalaryTextBox.Text = "";
            
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(studentIdTextBox.Text);
            string name = studentNameTextBox.Text;
            string department = studentDepartmentTextbox.Text;
            string semester = studentSemesterTextBox.Text;

            STUDENT dummy_student = new STUDENT();
            dummy_student.student_id = id;
            dummy_student.student_department = department;
            dummy_student.student_semester = semester;
            dummy_student.student_name = name;
            students.Add(dummy_student);

            MessageBox.Show("Successfully Saved");
        }

        private void saveTeacherButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(teacherIdTextBox.Text);
            string name = teacherNameTextBox.Text;
            string department = teacherDepartmentTextBox.Text;
            string designation = teacherDesignationTextBox.Text;
            int salary = Convert.ToInt32(teacherSalaryTextBox.Text);

            TEACHER dummy_teacher = new TEACHER();
            dummy_teacher.teacher_id = id;
            dummy_teacher.teacher_department = department;
            dummy_teacher.teacher_designation = designation;
            dummy_teacher.teacher_name = name;
            dummy_teacher.teacher_salary = salary;
            teachers.Add(dummy_teacher);

            MessageBox.Show("Successfully Saved");
        }

        private void saveAdminButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(adminIdTextBox.Text);
            string name = adminNameTextBox.Text;
            string designation = adminDesignationTextBox.Text;
            int salary = Convert.ToInt32(adminSalaryTextBox.Text);

            ADMIN dummy_admin = new ADMIN();
            dummy_admin.admin_id = id;
            
            dummy_admin.admin_designation = designation;
            dummy_admin.admin_name = name;
            dummy_admin.admin_salary = salary;
            admins.Add(dummy_admin);

            MessageBox.Show("Successfully Saved");
        }

        private void showStudentButton_Click(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();
            for(int i = 0; i < students.Count; i++)
            {
                studentListBox.Items.Add(students[i].getStudentInfo());
            }
        }

        private void showTeacherButton_Click(object sender, EventArgs e)
        {
            teacherListBox.Items.Clear();
            for (int i = 0; i < teachers.Count; i++)
            {
                teacherListBox.Items.Add(teachers[i].getTeacherInfo());
            }
        }

        private void showAdminButton_Click(object sender, EventArgs e)
        {
            adminListBox.Items.Clear();
            for (int i = 0; i < admins.Count; i++)
            {
                adminListBox.Items.Add(admins[i].getAdminInfo());
            }
        }
    }
}
