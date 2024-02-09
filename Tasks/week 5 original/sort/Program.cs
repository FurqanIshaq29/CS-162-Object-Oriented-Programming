using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            MUser u1 = new MUser("Zaid", 214, 165);
            MUser u2 = new MUser("Furqan", 199, 154);
            MUser u3 = new MUser("Tazeem", 128, 186);
            MUser u4 = new MUser("Aftab", 167, 240);

            List<MUser> userList = new List<MUser>() { u1, u2, u3, u4 };
            List<MUser> sortedList = userList.OrderByDescending(o => o.ecat).ToList();
            foreach(MUser user in sortedList)
            {
                Console.WriteLine("{0} \t {1} \t \t {2}", user.name, user.rollNumber, user.ecat);
            }
            Console.ReadKey();
        }
    }
}
