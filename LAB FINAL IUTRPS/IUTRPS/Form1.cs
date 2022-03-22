using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IUTRPSDEPENDENCIES;
using System.IO;

namespace IUTRPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"D:\OOC LAB\SWE4201MarkSheet.csv"))
            {

                
                while (!reader.EndOfStream)
                {
                    
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    double attendance;
                    double quiz1;
                    double quiz2;
                    double quiz3;
                    double quiz4;
                    double mid;
                    double final;
                    double viva;
                    if (values[2] == "") {
                        attendance = 0;
                    
                    }
                    else
                    {
                        attendance = Convert.ToDouble(values[2]);
                    }
                    if (values[3] == "")
                    {
                        quiz1 = 0;

                    }
                    else
                    {
                        quiz1 = Convert.ToDouble(values[3]);
                    }
                    if (values[4] == "")
                    {
                        quiz2 = 0;

                    }
                    else
                    {
                        quiz2 = Convert.ToDouble(values[4]);
                    }
                    if (values[5] == "")
                    {
                        quiz3 = 0;

                    }
                    else
                    {
                        quiz3 = Convert.ToDouble(values[5]);
                    }
                    if (values[6] == "")
                    {
                        quiz4 = 0;

                    }
                    else
                    {
                        quiz4 = Convert.ToDouble(values[6]);
                    }
                    if (values[7] == "")
                    {
                        mid = 0;

                    }
                    else
                    {
                        mid = Convert.ToDouble(values[7]);
                    }
                    if (values[8] == "")
                    {
                        final = 0;

                    }
                    else
                    {
                        final = Convert.ToDouble(values[8]);
                    }
                    if (values[9] == "")
                    {
                        viva = 0;

                    }
                    else
                    {
                        viva = Convert.ToDouble(values[9]);
                    }

                    STUDENT dummy_student = new STUDENT(values[0], values[1],attendance, quiz1, quiz2, quiz3, quiz4, mid, final, viva);

                    List<double> quizes = new List<double>();

                    quizes.Add(dummy_student.quiz1);
                    quizes.Add(dummy_student.quiz2);
                    quizes.Add(dummy_student.quiz3);
                    quizes.Add(dummy_student.quiz4);
                    quizes.Sort();

                    dummy_student.total = attendance + quizes[3] +quizes[2]+quizes[1]+ mid + final + viva;
                    dummy_student.percentage = (dummy_student.total / 3);
                    if (dummy_student.percentage >= 80)
                    {
                        dummy_student.grade = "A+";
                    }
                    else if(dummy_student.percentage <80 && dummy_student.percentage > 75)
                    {
                        dummy_student.grade = "A";
                    }
                    else if (dummy_student.percentage < 75 && dummy_student.percentage > 70)
                    {
                        dummy_student.grade = "A-";
                    }
                    else if (dummy_student.percentage < 70 && dummy_student.percentage > 65)
                    {
                        dummy_student.grade = "B+";
                    }
                    else if (dummy_student.percentage < 65 && dummy_student.percentage > 60)
                    {
                        dummy_student.grade = "B";
                    }
                    else if (dummy_student.percentage < 60 && dummy_student.percentage > 55)
                    {
                        dummy_student.grade = "C";
                    }
                    else if (dummy_student.percentage < 55 && dummy_student.percentage > 50)
                    {
                        dummy_student.grade = "D";
                    }
                    else
                    {
                        dummy_student.grade = "F";
                    }


                    RPS.students.Add(dummy_student);
                    idListBox.Items.Add(dummy_student.studentID);
                    nameListBox.Items.Add(dummy_student.studentName);
                    percentageListBox.Items.Add(Convert.ToString(Math.Round(dummy_student.percentage,2)));
                    gradeListBox.Items.Add(dummy_student.grade);


                   

                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idTextbox.Text;
            for(int i = 0; i < RPS.students.Count;i++)
            {
                if (id == RPS.students[i].studentID)
                {
                    STUDENT dummy = RPS.students[i];
                    attendanceLabel.Text = "Attendance : " + RPS.students[i].studentAttendance;
                    quiz1Label.Text = "Quiz 1 : " + RPS.students[i].quiz1;
                    quiz2Label.Text = "Quiz 2 : " + RPS.students[i].quiz2;
                    quiz3Label.Text = "Quiz 3 : " + RPS.students[i].quiz3;
                    quiz4Label.Text = "Quiz 4 : " + RPS.students[i].quiz4;

                    List<double> quizes2 = new List<double>();

                    quizes2.Add(dummy.quiz1);
                    quizes2.Add(dummy.quiz2);
                    quizes2.Add(dummy.quiz3);
                    quizes2.Add(dummy.quiz4);
                    quizes2.Sort();
                    double temp = 0;
                    for(int j = 1; j < 4; j++)
                    {
                        temp += quizes2[j];
                    }
                    quizTotalLabel.Text = "Quiz Total : " + temp;
                    midLabel.Text = "Mid : " + dummy.mid;
                    finalLabel.Text = "Final : " + dummy.final;
                    vivaLabel.Text = "Viva : " + dummy.viva;
                    totalLabel.Text = "Total : " + Math.Round(dummy.total,2);
                    percentageLabel.Text = "Percentage : " + Math.Round(dummy.percentage,2);
                    gradeLabel.Text = "Grade : " + dummy.grade;
                    break;
                }
            }
        }
    }
}
