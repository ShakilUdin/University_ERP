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

<<<<<<< HEAD
        public GradStudent(string fname, string lname, string address, string citi, int tel, int t1, int t2, int std,
            string thes,int res)
            : base(fname, lname, address, citi, tel, t1, t2, std, res)
=======
        public GradStudent(string fname, string lname, string address, string citi, int tel, int t1, int t2,
            int std_id)
            : base(fname, lname, address, citi, tel, t1, t2, std_id)
>>>>>>> f6a88ed249617d839af65ae1595208e2f9cfaa94
        {
            this.thesis = thes;
        }
    }
}
