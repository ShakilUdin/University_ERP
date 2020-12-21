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


        public override string ComputeGrade()
        {
            double result = (0.40 + test1) + (0.60 + test1);
            return result.ToString();
        }
    }
}
