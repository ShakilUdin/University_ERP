﻿namespace University_ERP.Models
{
    class GradStudent : FullTimeStudents
    {
        public GradStudent()
        {}

        public GradStudent(string fname, string lname, string address, string citi, int tel, int t1, int t2,
            int std_id)
            : base(fname, lname, address, citi, tel, t1, t2, std_id)
        {

        }
    }
}
