using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IUTLMS_dependencies;

namespace IUTLMS
{
    public partial class Form1 : Form
    {
        LMS lms = new LMS();
        public Form1()
        {
            InitializeComponent();
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            string name = teacherNameTextBox.Text;
            string type = teacherTypeComboBox.Text;
            if (type == "Lecturer")
            {

                LECTURER dummy_lecturer = new LECTURER(name);
                lms.lecturers.Add(dummy_lecturer);
                courseTeacherComboBox.Items.Add(name);
                showTeacherComboBox.Items.Add(name);
                MessageBox.Show("Lecturer Added.");
            }
            else
            {
                PROFESSOR dummy_professor = new PROFESSOR(name);
                lms.professors.Add(dummy_professor);
                courseTeacherComboBox.Items.Add(name);
                showTeacherComboBox.Items.Add(name);
                MessageBox.Show("Professor Added.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string code = courseCodeTextBox.Text;
            string type = courseTypeComboBox.Text;
            string title = courseTitleComboBox.Text;
            string semester = courseSemesterComboBox.Text;
            double credit = 0;
            string teacher = courseTeacherComboBox.Text;
            if (type == "lab")
            {
                credit = 1.5;
            }
            else
            {
                credit = 3;
            }
            COURSE dummy_course = new COURSE(title, type,teacher, semester, code, credit);
            for (int i = 0; i < lms.lecturers.Count || i < lms.professors.Count; i++)
            {
                if (teacher == lms.lecturers[i].entityName)
                {
                    lms.lecturers[i].courses.Add(dummy_course);
                    
                    break;
                }
                else if (teacher == lms.professors[i].entityName)
                {
                    lms.professors[i].courses.Add(dummy_course);
                    break;
                }
            }
            lms.availableCourses.Add(dummy_course);
            studentCourseComboBox.Items.Add(title);
            MessageBox.Show("Course Added.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = studentNameTextBox.Text;
            string semester = studentSemesterComboBox.Text;
            string course = studentCourseComboBox.Text;
            int flag = 0;
            
            for (int i = 0;i < lms.students.Count; i++){
                if (lms.students[i].entityName == name)
                {
                    for(int j = 0; j < lms.availableCourses.Count; j++)
                    {
                        if(course==lms.availableCourses[j].courseTitle && semester == lms.availableCourses[j].courseSemester)
                        {

                            lms.students[i].courses.Add(lms.availableCourses[j]);
                            flag = 1;
                            break;
                        }
                    }
                }
                               

                
            }
            if (flag==0) {
                STUDENT dummy_student = new STUDENT(name);
                for (int j = 0; j < lms.availableCourses.Count; j++)
                {
                    if (course == lms.availableCourses[j].courseTitle && semester == lms.availableCourses[j].courseSemester)
                    {

                        dummy_student.courses.Add(lms.availableCourses[j]);
                        flag = 1;
                        break;
                    }
                }
                lms.students.Add(dummy_student);
                showStudentComboBox.Items.Add(name);
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showStudentListBox.Items.Clear();
            string name = showStudentComboBox.Text;
            for(int i = 0; i < lms.students.Count; i++)
            {
                if (name == lms.students[i].entityName)
                {
                    showStudentListBox.Items.Add(lms.students[i].showInfo());
                    for (int j = 0; j < lms.students[i].courses.Count; j++)
                    {
                        string temp = lms.students[i].courses[j].courseCode + "\t" + lms.students[i].courses[j].courseType + "\t" + lms.students[i].courses[j].courseTitle + lms.students[i].courses[j].courseSemester;
                        showStudentListBox.Items.Add(temp);
                    }
                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showTeacherListBox.Items.Clear();
            string name = showTeacherComboBox.Text;
            for (int i = 0; i < lms.lecturers.Count || i<lms.professors.Count; i++)
            {
                if (i<lms.lecturers.Count && name == lms.lecturers[i].entityName)
                {
                    showTeacherListBox.Items.Add(lms.lecturers[i].showInfo());
                    for (int j = 0; j < lms.lecturers[i].courses.Count; j++)
                    {
                        string temp = lms.lecturers[i].courses[j].courseCode + "\t" + lms.lecturers[i].courses[j].courseType + "\t" + lms.lecturers[i].courses[j].courseTitle + "\t" + lms.lecturers[i].courses[j].courseSemester;
                       showTeacherListBox.Items.Add(temp);
                    }
                    break;
                }
                else if (i<lms.professors.Count && name == lms.professors[i].entityName)
                {
                    showTeacherListBox.Items.Add(lms.professors[i].showInfo());
                    for (int j = 0; j < lms.professors[i].courses.Count; j++)
                    {
                        string temp = lms.professors[i].courses[j].courseCode + "\t" + lms.professors[i].courses[j].courseType + "\t" + lms.professors[i].courses[j].courseTitle + "\t" + lms.professors[i].courses[j].courseSemester;
                        showTeacherListBox.Items.Add(temp);
                    }
                    break;
                }
            }
        }

        private void showTeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showStudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
