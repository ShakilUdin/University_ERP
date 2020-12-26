using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    class UnderGradStudent : FullTimeStudents
    {
        public UnderGradStudent()
        {}

        public UnderGradStudent(int std_id, string fname, string lname, string address, string citi, int tel, int t1, int t2)
        : base(std_id, fname, lname, address, citi, tel, t1, t2)
        {

        }
    }
}
