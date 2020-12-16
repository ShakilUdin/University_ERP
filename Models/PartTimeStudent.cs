using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    class PartTimeStudent : FullTimeStudents
    {
        private int voter_id;

        public int VoterId
        {
            get => voter_id;
            set => voter_id = value;
        }

        
        public override string ComputeGrade(int t1, int t2)
        {
            double result = (0.40 + t1) + (0.60 + t2);
            return result.ToString();
        }
    }
}
