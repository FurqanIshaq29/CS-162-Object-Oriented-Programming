using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        class STUDENT
        {
            public STUDENT()
            {
                name = "Jill";
                matricMarks = 1059F;
                ecatMarks = 154F;
                fscMarks = 1059F;
                aggregate = 96.27F;
            }
            public string name;
            public float matricMarks;
            public float ecatMarks;
            public float fscMarks;
            public float aggregate;

        }
        static void Main(string[] args)
        {
            // task_();
            // task__();
            // task1a();
            task1b();
            Console.ReadKey();
        }

        static void task_()
        {
            STUDENT s1 = new STUDENT();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.aggregate);

        }

        static void task2__()
        {
            STUDENT s1 = new STUDENT();
            Console.WriteLine(s1.name);
        }

        static void task1a()
        {
            STUDENT s1 = new STUDENT();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.aggregate);

        }
        static void task1b()
        {
            STUDENT s1 = new STUDENT();
            STUDENT s2 = new STUDENT();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.aggregate);

            Console.WriteLine(s2.name);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.aggregate);

        }
    }
}
