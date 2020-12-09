using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    abstract class FullTimeStudents : Students
    {
        int voter_id;

        public int VoterId
        {
            get => voter_id;
            set => voter_id = value;
        }

        public FullTimeStudents()
        {}

        public FullTimeStudents(string fname, string lname, string address, string citi, int tel, int t1, int t2, int voter)
        :base(fname, lname, address, citi, tel, t1, t2)
        {
            this.voter_id = voter;
        }
    }

   


}
