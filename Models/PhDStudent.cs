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
        private int test1;
        private int test2;

        public string Phdadvisor
        {
            get => phdadvisor;
            set => phdadvisor = value;
        }

        public int Test2
        {
            get => test2;
            set => test2 = value;
        }

        public int Test1
        {
            get => test1;
            set => test1 = value;
        }

        public PhDStudent()
        {
        }

        public PhDStudent(string fname, string lname, string address, string citi, int tel, int t1, int t2,
            string advisor)
            : base(fname, lname, address, citi, tel)
        {
            this.phdadvisor = advisor;
        }

        public override string ComputeGrade()
        {
            double result = (0.30 + test1) + (0.70 + test2);
            return result.ToString();
        }
    }
}
