using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    internal class ADMIN
    {
        public int admin_id;
        public string admin_name;
        public string admin_designation;
        public int admin_salary;


        public string getAdminInfo()
        {
            string teacher_info = admin_id.ToString() + "\t" + admin_name  + "\t" + admin_designation + "\t" + admin_salary.ToString();

            return teacher_info;
        }
    }
}
