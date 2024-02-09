using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignupSignin
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\OOP 23\\SignupSignin\\Sign.txt";
            string[] names = new string[5];
            string[] passwords = new string[5];
            int option = 0;
            while (option != 3)
            {
                readData(path, names, passwords);
              
                Console.Clear();
                option = menus();
                if (option == 1)
                {
                    Console.WriteLine("Enter new name : ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter new password : ");
                    string p = Console.ReadLine();
                    SignUp(path,n, p);

                }

                else if (option == 2)
                {
                    Console.WriteLine("Enter name : ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter password : ");
                    string p = Console.ReadLine();
                    SignIn(n, p, names, passwords);

                }

            }
            Console.Read();

        }

        static void SignUp(string path,string n,string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();

        }

        static void SignIn(string n, string p, string[] names, string[] passwords)
        {
            bool flag = false;
            for(int x = 0;x < 5;x++)
            {
                if(n == names[x] && p == passwords[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }

            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.Read();

        }
         static int menus()
        {
            int option;
            Console.WriteLine("1. SignUp");
            Console.WriteLine("2. SignIn");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Choose one of the following.....");
            option = int.Parse( Console.ReadLine());
            return option;
        }

        static void readData(string path,string[] name,string[] password)
        {
            int x = 0;
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while((record = file.ReadLine()) != null)
                {
                    name[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if(x >= 5)
                    {
                        break;
                    }

                }
                file.Close();
            }

            else
            {
                Console.WriteLine("File Doesn't Exists");
            }

        }

        //parse the name and password 
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for(int i = 0; i < record.Length;i++)
            {
                if(record[i] == ',')
                {
                    comma++;
                }

                else if (comma == field)
                {
                    item = item + record[i];

                }

            }
            return item;

        }
    }
}
