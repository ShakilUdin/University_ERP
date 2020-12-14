using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    abstract class FullTimeStudents : Students
    {

        int result;
        int student_id;

        public int Result
        {
            get => result;
            set => result = value;
        }

        public int StudentId
        {
            get => student_id;
            set => student_id = value;
        }

        public FullTimeStudents()
        {
        }

        public FullTimeStudents(string fname, string lname, string address, string citi, int tel, int t1, int t2, int res, int std_id)
            : base(fname, lname, address, citi, tel, t1, t2)
        {
            this.result = res;
            this.student_id = std_id;
        }
    }
}
