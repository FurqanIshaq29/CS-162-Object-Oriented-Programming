using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using siii.BusinessLayer;
using siii.DataLayer;
using siii.UserInterface;

namespace siii
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "users.txt";
            MUserDL.loadUser(path);
            string option = menu();
            while (option != "3")
            {
                if (option == "1")
                {
                    MUser u1 = MUserUI.inputWithoutRole();
                    if (u1 != null)
                    {
                        u1 = MUserDL.SignIn(u1);
                        if (u1 == null)
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        else if (MUser.isRole(u1) == true)
                        {
                            Console.WriteLine("Admin Menu");
                            Console.ReadKey();
                        }
                        else 
                        {
                            Console.WriteLine("User Menu");
                            Console.ReadKey();

                        }
                        Console.ReadKey();
                    }
                }
                else if (option == "2")
                {
                    MUser u2 = MUserUI.inputWithRole();
                    if (u2 == null)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    {
                        MUserDL.storeDataInList(u2);
                        MUserDL.storeUser(path, u2);
                        Console.WriteLine("Signed Up Successfully...");
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                    Console.ReadKey();

                }
                Console.Clear();
                option = menu();
            }

        }

        static string menu()
        {
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your option: ");
            string op = Console.ReadLine();
            return op;
        }
    }
}



