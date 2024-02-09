using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class SIGNUP
        {
            public string id;
            public string password;
        }
        class PRODUCT
        {
            public string brandName;
            public string productName;
            public string category;
            public string price;
            public string description;
            public string review;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            topHeader();
            string login




            Console.ReadKey();


        }

        //Main header 
        static void topHeader()
        {
            Console.WriteLine("                   #@@@@@@@    @@@        @@@      ######         ");
            Console.WriteLine("                   #           @@  @     @ @@     #      #        ");
            Console.WriteLine("                   #           @@   @   @  @@     #               ");
            Console.WriteLine("                   #@@@@@@     @@    @ @   @@      # # # #        ");
            Console.WriteLine("                   #           @@     @    @@             #       ");
            Console.WriteLine("                   #           @@          @@      #      #       ");
            Console.WriteLine("                   #@@@@@@@    @@          @@       ######        ");
            Console.WriteLine(" ");
            Console.WriteLine("              ###############################################     ");
            Console.WriteLine("              ******** E-COMMERCE MANAGEMENT SYSTEM *********     ");
            Console.WriteLine("              ###############################################     ");
            Console.WriteLine("                         WELCOME TO E-COMMERCE SYSTEM             ");
        }

        //login menu for users
        static string loginMenu()
        {
            string option;
            Console.WriteLine("Choose one option ");
            Console.WriteLine("1. Press 1 to SIGN IN : ");
            Console.WriteLine("2. Press 2 to SIGN UP : ");
            Console.WriteLine("3. Exit ");
            Console.WriteLine("Enter the option : ");
            option = Console.ReadLine();
            return option;
        }
    }
}
