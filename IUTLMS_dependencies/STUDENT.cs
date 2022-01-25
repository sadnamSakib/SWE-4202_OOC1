using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTLMS_dependencies
{
    public class STUDENT:ENTITY
    {
        private string studentSemester;
        public STUDENT(string name)
        {
            this.entityName = name;
        }
        public override string showInfo()
        {
            string temp = this.entityName + "\t\t" + this.studentSemester + "\t\t";
            
            return temp;
        }
        
    }
}
