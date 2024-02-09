using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Student s1 = new Student("Furqan", "Lahore", "BS CS", 2022, 50000);
            Student s2 = new Student("Ali", "Pakpattan", "BS ME", 2021, 57000);

            Staff sa1 = new Staff("azam", "lodhran", "BHPS", 30000);
            Staff sa2 = new Staff("zahid", "nolakha", "APS", 35000);


            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
            Console.WriteLine(sa1.ToString());
            Console.WriteLine(sa2.ToString());

            Console.ReadKey();
        }
    }
}

/* Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Address : ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Program : ");
            String program = Console.ReadLine();
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fees : ");
            double fees = double.Parse(Console.ReadLine());
*/