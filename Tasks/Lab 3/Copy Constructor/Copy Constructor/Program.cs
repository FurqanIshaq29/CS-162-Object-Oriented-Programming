using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor
{
    class Program
    {
        class students
        {
            public students()
            {
                Console.WriteLine("Default Constructor");
            }

            public students(students s)
            {
                sname = s.sname;
                matricMarks = s.matricMarks;
                fscMarks = s.fscMarks;
                ecatMarks = s.ecatMarks;
                aggregate = s.aggregate;
            }
            public string sname;
            public float matricMarks;
            public float fscMarks;
            public float ecatMarks;
            public float aggregate;
        }
        static void Main(string[] args)
        {
            copyConstructorCall();
        }

        static void copyConstructorCall()
        {
            students s1 = new students();
            s1.sname = "Jack";
            students s2 = new students(s1);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s2.sname);
            Console.Read();
        }
    }
}
