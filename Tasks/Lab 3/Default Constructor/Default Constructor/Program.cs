using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Constructor
{
    class Program
    {
        class student
        {
            public student()
            {
                sname = "Jill";
                matricMarks = 1038F;
                fscMarks = 1049F;
                ecatMarks = 165F;
                aggregate = 79.015F;
            }
            public string sname;
            public float matricMarks;
            public float fscMarks;
            public float ecatMarks;
            public float aggregate;
        }

        class stu
        {
            public string sname;
            public float matricMarks;
            public float fscMarks;
            public float ecatMarks;
            public float aggregate;
        }
        static void Main(string[] args)
        {
            task1b();
        }

        static void task1a()
        {
            student s1 = new student();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);

            Console.Read();
        }

        static void task1b()
        {
            student s1 = new student();
            student s2 = new student();

            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);

            Console.WriteLine(s2.sname);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);

            Console.Read();
        }
    }
}
