using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class MUser
    {
            public string name;
            public int rollNumber;
            public int ecat;

        public MUser(string username,int rollnumber,int ecat)
        {
            this.name = username;
            this.rollNumber = rollnumber;
            this.ecat = ecat;
        }
    }
}
