using System.Runtime.Versioning;

namespace University_ERP.Models
{
    class GradStudent : FullTimeStudents
    {
        private string thesis;

        public string Thesis
        {
            get => thesis;
            set => thesis = value;
        }

        public GradStudent()
        {}


        public GradStudent(int std_id, string fname, string lname, string address, string citi, int tel, int t1, int t2, string thises)
        : base(std_id, fname, lname, address, citi, tel, t1, t2)
        {
            this.thesis =  thises;
        }
    }
}
