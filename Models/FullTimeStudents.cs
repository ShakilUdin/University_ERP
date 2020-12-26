using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    abstract class FullTimeStudents : Students
    {
        int student_id;
        protected int test1;
        protected int test2;

        public int StudentId
        {
            get => student_id;
            set => student_id = value;
        }

        protected int Test1
        {
            get => test1;
            set => test1 = value;
        }

        protected int Test2
        {
            get => test2;
            set => test2 = value;
        }

        public FullTimeStudents()
        {

        }

        public FullTimeStudents(int std_id, string fname, string lname, string address, string citi, int tel, int t1, int t2)
        :base(fname, lname, address, citi, tel)
        {
            this.student_id = std_id;
            this.test1 = t1;
            this.test2 = t2;
        }


        public override string ComputeGrade()
        {
            double result = (0.40 + Test1) + (0.60 + Test2);
            return result.ToString();
        }
    }
}
