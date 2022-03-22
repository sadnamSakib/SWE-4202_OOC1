using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTRPSDEPENDENCIES
{
    public class STUDENT
    {
        public string studentID;
        public string studentName;
        public double studentAttendance, quiz1, quiz2, quiz3, quiz4, mid, final, viva,percentage,total;
        public string grade = "";
        public STUDENT(string id,string name,double attendance,double quiz1,double quiz2,double quiz3,double quiz4,double mid,double final , double viva )
        {
            this.studentID = id;
            this.studentName = name;
            this.studentAttendance = attendance;
            this.quiz1 = quiz1;
            this.quiz2 = quiz2;
            this.quiz3 = quiz3;
            this.quiz4 = quiz4;
            this.mid = mid;
            this.final = final;
            this.viva = viva;
        }
        public List<double> quizes = new List<double>();

        
    }
}
