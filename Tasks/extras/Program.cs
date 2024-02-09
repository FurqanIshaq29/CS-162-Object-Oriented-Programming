using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extras
{
    class Program
    {
        class student
            {
            public string name;
            public float urduMarks;
            public float englishMarks;
            public float mathMarks;
            public float total;
            }
        static student takeInput()
        {
            student s1 = new student();

            Console.Write("Enter the name : ");
            s1.name = Console.ReadLine();

            Console.Write("Enter urdu marks : ");
            s1.urduMarks = float.Parse(Console.ReadLine());

            Console.Write("Enter English Marks : ");
            s1.englishMarks = float.Parse(Console.ReadLine());

            Console.Write("Enter Maths Marks : ");
            s1.mathMarks = float.Parse(Console.ReadLine());
            return s1;

        }

        static void totalSum(student s)
        {
            s.total = s.englishMarks + s.urduMarks + s.mathMarks;
        }

        static void Output(student s)
        {
            Console.WriteLine(s.name + "\t" + s.total);

        }
        static void Main(string[] args)
        {
            List<student> stu = new List<student>(3);
            for(int i = 0;i <stu.Count ;i++)
            {
                stu.Add(takeInput());
            }
            Console.WriteLine("Name\tTotal Marks");

            for (int i = 0; i < stu.Count; i++)
            {
                totalSum(stu[i]);
                Output(stu[i]);
            }
            Console.ReadKey();

        }
        

    }
}
