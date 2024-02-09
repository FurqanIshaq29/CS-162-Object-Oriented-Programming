using SelfAssessment2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_assesment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<credential> crd = new List<credential>();
            int op = 0;
            while (op != 3)
            {
                op = option();
                if (op == 1)
                {
                    Console.Clear();
                    crd.Add(addUser());
                }

                else if (op == 2)
                {
                    if (crd.Count != 0)
                    {
                        Console.Clear();
                        List<credential> sortedData = crd.OrderBy(c => c.userID).ToList();
                        Console.WriteLine("Username \t Password \t User ID");

                        foreach (credential cr in sortedData)
                        {
                            Console.WriteLine("{0} \t \t {1} \t \t {2}", cr.name, cr.password, cr.userID);
                        }
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("No record found");
                        Console.ReadKey();
                    }
                }
            }
        }

        void main()
        {
            List<credential> crd = new List<credential>();
            int op = 0;
            while (op != 3)
            {
                if(op == 1)
                {
                    Console.Clear();
                    crd.Add(addUser());
                }

                if(op == 2)
                {
                    if(crd.Count != 0)
                    {
                        List<credential> sortedData = crd.OrderBy(c => c.userID).ToList(); 
                    }
                    else
                    {
                        Console.WriteLine("No Record Found");
                    }
                }


            }
        }

        static credential addUser()
        {
            Console.WriteLine("Enter Username: ");
            string nam = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string pas = Console.ReadLine();

            Console.WriteLine("Enter User ID: ");
            int usid = int.Parse(Console.ReadLine());

            credential crd = new credential(nam, pas, usid);

            return crd;

        }

        static credential adduser()
        {
            Console.WriteLine("USer name : ");
            string n = Console.ReadLine();
            Console.WriteLine("password : ");
            string p = Console.ReadLine();
            Console.WriteLine("USer ID : ");
            int u = int.Parse(Console.ReadLine());
            credential crd = new credential(n,p,u);
            return crd;
        }
        static int option()
        {
            Console.Clear();
            int op = 0;
            Console.WriteLine("1. Add User: ");
            Console.WriteLine("2. View sorted Data: ");
            Console.WriteLine("3. EXIT: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        static int option1()
        {
            Console.Clear();
            return option();
        }
    }
}