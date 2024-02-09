using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        class Students
        {
            public string name;
            public int rollNumber;
            public float cGPA;
            public int matricMarks;
            public int fscMarks;
            public int eCatMarks;
            public string homeTown;
            public char hostalide;
            public char isTakingScholarship;

            public Students(string n, int r, float cgp, int mm, int fsc, int em, string ht, char h, char isH)
            {
                this.name = n;
                this.rollNumber = r;
                this.cGPA = cgp;
                this.matricMarks = mm;
                this.fscMarks = fsc;
                this.eCatMarks = em;
                this.homeTown = ht;
                this.hostalide = h;
                this.isTakingScholarship = isH;
            }

            public float merit()
            {
                float a = fscMarks/1100f;
                float b = a*100f;
                float c = b * 0.6f;

                float d = eCatMarks/400f;
                float e = d * 100f;
                float f = e * 0.4f;

                float interMerit = c + f;
                return interMerit;
            }

            public bool isEligibleForScholarship()
            {
                float meritlist = merit();

                if(meritlist > 80)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            List<Students> stud = new List<Students>();

            int op = 0;

            int count = 0;

            while(op != 5)
            {
                op = option();
                if (op == 1)
                {
                    Console.Clear();
                    stud.Add(addStudent());
                    count++;
                }
                else if(op == 2)
                {
                    Console.Clear();
                    foreach(Students storedUser in stud)
                    {
                        Console.WriteLine("Name: {0}", storedUser.name);
                        Console.WriteLine("Roll No.: {0}", storedUser.rollNumber);
                        float merit = storedUser.merit();
                        Console.WriteLine("The merit of the student is: {0}" , merit);
                        Console.ReadKey();
                    }
                }
                else if(op == 3)
                {
                    Console.Clear();
                    foreach(Students us in stud)
                    {
                        bool a = us.isEligibleForScholarship();
                        if(a == true)
                        {
                            Console.WriteLine("Name: {0}",us.name);
                            Console.WriteLine("Roll No.: {0}",us.rollNumber);
                            Console.WriteLine("Congratulations!!! You are Eligible for Scholarship.");
                        }
                        else
                        {
                            Console.WriteLine("Name: {0}", us.name);
                            Console.WriteLine("Roll No.: {0}", us.rollNumber);
                            Console.WriteLine("According to your merit You are not Eligible for Scholarship.");
                        }
                        Console.ReadKey();
                    }
                }
                Console.Clear();
            }
        }

        static Students addStudent()
        {

            Console.WriteLine("Enter the Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Roll No.: ");
            int roll = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CGPA: ");
            float cgpa = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Matric Marks: ");
            int matric = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the FSC Marks: ");
            int fsc = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the ECAT Marks: ");
            int ecat = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the HomeTown: ");
            string homeTown = Console.ReadLine();

            Console.WriteLine("Enter the your are Hostalide or Not(y/n): ");
            char host = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter is getting Scholarship or Not(y/s): ");
            char scholar = char.Parse(Console.ReadLine());

            Students stu = new Students(name,roll,cgpa,matric,fsc,ecat,homeTown,host,scholar);

            return stu;
        }

        static int option()
        {
            int op;
            Console.WriteLine("Enter 1 for Add Students: ");
            Console.WriteLine("Enter 2 for View Merit: ");
            Console.WriteLine("Enter 3 for Scholarship Status: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
