using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    class PhDStudent : Students
    {
        string phdadvisor;

        public string Phdadvisor
        {
            get => phdadvisor;
            set => phdadvisor = value;
        }

        public PhDStudent()
        {
        }

        public PhDStudent(string fname, string lname, string address, string citi, int tel, int t1, int t2,
            string advisor)
            : base(fname, lname, address, citi, tel, t1, t2)
        {
            this.phdadvisor = advisor;
        }

        public override string ComputeGrade(int test1, int test2)
        {
            double result = (0.30 + test1) + (0.70 + test2);
            return result.ToString();
        }
    }
}
