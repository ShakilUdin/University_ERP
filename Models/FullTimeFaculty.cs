using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_ERP.Models
{
    class FullTimeFaculty : Employee
    {
        private int id;
        private int voterid;

        public int Voterid
        {
            get => voterid;
            set => voterid = value;
        }
    }
}
