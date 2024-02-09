using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterizedconstructor
{
    class Program
    {
        class STUDENT
        {  /*
            public STUDENT()
            {
                Console.WriteLine("Default Constructor");
            }

            public STUDENT(STUDENT s)
            {
                sname = s.sname;
                matricMarks = s.matricMarks;
                fscMarks = s.fscMarks;
                ecatMarks = s.ecatMarks;
                aggregate = s.aggregate;
            }
            public STUDENT(string n, float a, float b, float c, float d)
              {
                  sname = n;
                  matricMarks = a;
                  fscMarks = b;
                  ecatMarks = c;
                  aggregate = d;
              }

              public string sname;
              public float matricMarks;
              public float fscMarks;
              public float ecatMarks;
              public float aggregate;
            */
        }
        static void Main(string[] args)
        {
            // task();
            //task1a();
            //task1b();
            // task_();
            task__();
            Console.ReadKey();
        }

        /*static void task()
        {
              STUDENT s1 = new STUDENT("John");
              Console.WriteLine(s1.sname);
              STUDENT s2 = new STUDENT("Jack");
              Console.WriteLine(s2.sname);*/



        /*static void task1a()
        {
            STUDENT s1 = new STUDENT("John", 1059F, 1059F, 154F, 96.27F);
            Console.WriteLine("{0} {1} {2} {3} {4}", s1.sname, s1.matricMarks, s1.fscMarks, s1.ecatMarks, s1.aggregate);
        }


        static void task1b()
        {
            STUDENT s1 = new STUDENT("John", 1059F, 1059F, 154F, 96.27F);
            Console.WriteLine("{0} {1} {2} {3} {4}", s1.sname, s1.matricMarks, s1.fscMarks, s1.ecatMarks, s1.aggregate);
            STUDENT s2 = new STUDENT("Jack", 1032F, 938F, 156F, 90.21F);
            Console.WriteLine("{0} {1} {2} {3} {4}", s2.sname, s2.matricMarks, s2.fscMarks, s2.ecatMarks, s2.aggregate);


        }

        //copy constructor
        static void task_()
        {
            STUDENT s1 = new STUDENT();
            s1.sname = "JACK";
            STUDENT s2 = new STUDENT(s1);

            Console.WriteLine(s1.sname);
            Console.WriteLine(s2.sname);
            s1.sname = "Joe";
            Console.WriteLine(s1.sname);
            Console.WriteLine(s2.sname);



        }*/

        static void task__()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}
