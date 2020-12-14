using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    abstract class FullTimeStudents : Students
    {
<<<<<<< HEAD
        int result;
        
=======
        int student_id;
        int result;

       
>>>>>>> f6a88ed249617d839af65ae1595208e2f9cfaa94
        public int Result
        {
            get => result;
            set => result = value;
        }

<<<<<<< HEAD
=======
        public int StudentId
        {
            get => student_id;
            set => student_id = value;
        }
>>>>>>> f6a88ed249617d839af65ae1595208e2f9cfaa94

        public FullTimeStudents()
        {}

<<<<<<< HEAD
        public FullTimeStudents(string fname, string lname, string address, string citi, int tel, int t1, int t2, int res)
        :base(fname, lname, address, citi, tel, t1, t2)
        {
            this.result = res;

=======
        public FullTimeStudents(string fname, string lname, string address, string citi, int tel, int t1, int t2, int std_id)
        :base(fname, lname, address, citi, tel, t1, t2)
        {
            this.student_id = std_id;
>>>>>>> f6a88ed249617d839af65ae1595208e2f9cfaa94
        }
    }
}
