using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //writeFile();
            readFile();
            Console.ReadKey();

        }

        static void writeFile()
        {
            string path = "D:\\OOP 23\\Week1FileHandling\\furqan.txt";
           StreamWriter file = new StreamWriter(path, true);
            file.WriteLine("Hello World");
            file.Flush();
            file.Close();
        }

        static void readFile()
        {
            string path = "D:\\OOP 23\\Week1FileHandling\\furqan.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path, true);
                string record;
                while((record = file.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
            }

            else
            {
                Console.WriteLine("Not Found");
            }

        }
    }
}
