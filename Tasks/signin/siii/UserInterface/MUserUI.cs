using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using siii.BusinessLayer;
using siii.DataLayer;

namespace siii.UserInterface
{
    class MUserUI
    {
        public static MUser inputWithRole()
        {
            Console.Write("Enter the new Name :");
            string name = Console.ReadLine();
            Console.Write("Enter the new Password :");
            string password = Console.ReadLine();
            Console.Write("Enter the new Role :");
            string role = Console.ReadLine();
            if (name != null && password != null && role!= null)
            {
                MUser u1 = new MUser(name, password, role);
                return u1;
            }
            else
            {
                return null;
            }
        }

        public static MUser inputWithoutRole()
        {
            Console.Write("Enter the Name :");
            string name = Console.ReadLine();
            Console.Write("Enter the Password :");
            string password = Console.ReadLine();
            if (name != null && password != null)
            {
                MUser u1 = new MUser(name, password);
                return u1;
            }
            else
            {
                return null;
            }
        }
        }
    }
