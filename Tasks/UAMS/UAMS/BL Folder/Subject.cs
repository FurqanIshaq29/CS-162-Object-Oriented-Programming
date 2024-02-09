using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Subject
    {
        public string type;
        public string code;
        public int creditHours;
        public int subjectFee;

        public Subject(string type, int creditHours, string code,int subjectFee)
        {
            this.type = type;
            this.creditHours = creditHours;
            this.code = code;
            this.subjectFee = subjectFee;
        }
    }
}
