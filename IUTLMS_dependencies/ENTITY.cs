using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTLMS_dependencies
{
    public abstract class ENTITY
    {
        public string entityName;
        public string entityContactNo;
        public string entityEmail;
        public string entityAddress;
        public List<COURSE> courses = new List<COURSE>();

        public abstract string showInfo();
        
           
        

    }
}
