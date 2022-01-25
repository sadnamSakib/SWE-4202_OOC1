using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTLMS_dependencies
{
    public  class TEACHER:ENTITY
    {
        public double teacherCredit;
        
        public override string showInfo()
        {
           string temp= this.entityName + "\t\t" +  "\t\t";
            return temp;
        }
        public void addCredit(int n)
        {
            this.teacherCredit += n;
        }
    }
}
