using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Name = new List<string>();
            List<float> Number = new List<float>();
            for(int i = 0; i < 5;i++)
            {
                Console.WriteLine("Enter the Name " + (i + 1) + " : ");
                string n = Console.ReadLine();
                Name.Add(n);
                Console.WriteLine("Enter the number " + (i + 1) + " : ");
                float b = float.Parse(Console.ReadLine());
                Number.Add(b);
            }
            Name.Sort();
            Number.Sort();
            foreach(string na in Name)
            {
                Console.WriteLine(na);
            }
            foreach (float ba in Number)
            {
                Console.WriteLine(ba);
            }
            Console.ReadKey();

        }
    }
}
