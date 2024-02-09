using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.DL
{
    class MUser
    {
        private static List<MUser> userList = new List<MUser>();

        public void addUserIntoList(MUser user)
        {
            userList.Add(user);
        }

        public static MUser signIn(MUser user)
        {
            foreach(MUser f in userList)
            {
                if
            }
        }
    }
}
