using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTLMS_dependencies
{
    public class LECTURER:TEACHER
    {
        public double teacherCredit = 1.5;
        public LECTURER(string name)
        {
            this.entityName = name;
        }
        public override string showInfo()
        {
            string temp = this.entityName + "\t" + "LECTURER";
            
                return temp;
                
        }
    }
}
