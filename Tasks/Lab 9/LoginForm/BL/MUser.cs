using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.BL
{
    class MUser
    {
        private string userName;
        private string userPassword;
        private string userRole;

        public MUser(string n,string p,string r)
        {
            this.userName = n;
            this.userPassword = p;
            this.userRole = r;
        }

        public MUser(string n, string p)
        {
            this.userName = n;
            this.userPassword = p;
            this.userRole = "NA";
        }

        public string getUserName()
        {
            return userName;
        }

        public string getUserPassword()
        {
            return userPassword;
        }

        public string getUserRole()
        {
            return userRole;
        }

        public bool isAdmin()
        {
            if (userRole.ToLower() == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    }
