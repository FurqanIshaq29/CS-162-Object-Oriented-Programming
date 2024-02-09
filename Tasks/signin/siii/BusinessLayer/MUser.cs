using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using siii.DataLayer;
namespace siii.BusinessLayer
{
    class MUser
    {
        public string name;
       public string password;
       public string role;

        public MUser()
        {

        }

        public MUser(string n,string p,string r)
        {
            this.name = n;
            this.password = p;
            this.role = r;

        }

        public MUser(string n,string p)
        {
            this.name = n;
            this.password = p;
        }

        public static bool isRole(MUser m)
        {
   
                if(m.role.ToLower() == "admin" )
                {
                    return true;
                }              
            
            return false;
        }


    }
}
