using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SignUpSignIn
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Object Oriented Programming 2023\\week 1\\Lab 1\\signin.txt";
            string[] names = new string[5];
            string[] passwords = new string[5];
            string option;
            int num;

            do
            {
                readData(path, names, passwords);
                Console.Clear();
                option = Menu();
                Console.Clear();
                
                if (option == "1")
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    signIn(n, p, names, passwords);
                    Console.Clear();
                }

                else if (option == "2")
                {
                    Console.WriteLine("Enter New Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter New Passwrds: ");
                    string p = Console.ReadLine();
                    signUp(path, n, p);
                }

                else if (option == "3")
                {
                    Console.WriteLine("Thanks For Using!!");
                    Console.ReadKey();
                    break;
                }
                num = int.Parse(option);
            }
            while (num < 4);
            Console.Read();
        }

        static string Menu()
        {
            string option;
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter Option");
            option = Console.ReadLine();
            Console.WriteLine(option);
            return option;
        }

        static void readData(string path, string[] names, string[] passwords)
        {
            int x = 0;
            if (File.Exists(path))
            {

                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    passwords[x] = parseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
        }

        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        static void signIn(string nam, string pass, string[] name, string[] password)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (nam == name[x] && pass == password[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }

        static void signUp(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }
    }
}