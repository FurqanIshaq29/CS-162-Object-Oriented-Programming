using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment2
{
    class credential
    {
        public string name;
        public string password;
        public int userID;

        public credential(string username,string password,int ID )
        {
            this.name = username;
            this.password = password;
            this.userID = ID;
        }
    }
}
