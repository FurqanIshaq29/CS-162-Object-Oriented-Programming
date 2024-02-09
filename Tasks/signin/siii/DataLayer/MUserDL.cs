using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using siii.BusinessLayer;
using siii.UserInterface;
using System.IO;

namespace siii.DataLayer
{
    class MUserDL
    {
        public static List<MUser> userList = new List<MUser>();

        public static void storeDataInList(MUser user)
        {
            userList.Add(user);
        }

        public static MUser SignIn(MUser m)
        {
            foreach(MUser t in userList)
            {
                if(t.name == m.name && t.password == m.password)
                {
                    return t;
                }
            }
            return null;

        }
        public static void loadUser(string path)
        {
            string line;
            if (File.Exists(path))
            {
                StreamReader read = new StreamReader(path);
                while ((line = read.ReadLine()) != null)
                {
                    string[] userFields = line.Split(',');
                    MUser u1 = new MUser();
                    u1.name = userFields[0];
                    u1.password = userFields[1];
                    u1.role = userFields[2];
                    userList.Add(u1);
                }
                read.Close();
            }

        }

        public static void storeUser(string path,MUser user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.name + "," + user.password + "," + user.role);
            file.Flush();
            file.Close();
        }
    }
}
