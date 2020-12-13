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

        public GradStudent(string fname, string lname, string address, string citi, int tel, int t1, int t2, int std,
            string thes,int res)
            : base(fname, lname, address, citi, tel, t1, t2, std, res)
        {
            this.thesis = thes;
        }
    }
}
