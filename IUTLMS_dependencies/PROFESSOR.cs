using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTLMS_dependencies
{
    public  class PROFESSOR:TEACHER
    {
        public double teacherCredit = 3;
        public PROFESSOR(string name)
        {
            this.entityName = name;
        }
        public override string showInfo()
        {
            string temp = this.entityName + "\t" + "PROFESSOR";
            for (int i = 0; i < this.courses.Count; i++)
            {
                temp += "\n" + courses[i].courseCode + "\t" + courses[i].courseType + "\t" + courses[i].courseTitle + "\t" + courses[i].courseSemester + "\t" + "CREDIT : " + this.teacherCredit;
            }
            return temp;

        }
    }
}
