using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siii.DL
{
    class FUser
    {
        public static List<FUser> userList = new List<FUser>();
        public static void storeDataInList(FUser user)
        {
            userList.Add(user);
        }
    }
}
