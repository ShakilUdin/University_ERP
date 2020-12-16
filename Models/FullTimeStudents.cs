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
        protected int test_1;
        protected int test_2;

      
        public int StudentId
        {
            get => student_id;
            set => student_id = value;
        }

        protected int Test1
        {
            get => test_1;
            set => test_1 = value;
        }

        protected int Test2
        {
            get => test_2;
            set => test_2 = value;
        }


        public FullTimeStudents()
        {
        }

        public FullTimeStudents(string fname, string lname, string address, string citi, int tel, int t1, int t2, int res, int std_id)
            : base(fname, lname, address, citi, tel, t1, t2)
        {
            
        }

        public override string ComputeGrade(int t1, int t2)
        {
            double result = (0.40 + t1) + (0.60 + t2);
            return result.ToString();
        }
    }
}
