using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    class PartTimeStudent : FullTimeStudents
    {

        public PartTimeStudent()
        {}

        public PartTimeStudent(string fname, string lname, string address, string citi, int tel, int t1, int t2,
            int voter) : base(fname, lname, address, citi, tel, t1, t2, voter)
        {}

        public override string ComputeGrade()
        {
            double result = (0.40 + test_1) + (0.60 + test_2);
            return result.ToString();
        }
    }
}
