using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cats");
            Console.Write("1.Cat Name : ");
            string n1 = Console.ReadLine();
            Cat c1 = new Cat(n1);
            Console.Write("2.Cat Name : ");
            string n2 = Console.ReadLine();
            Cat c2 = new Cat(n2);

            Console.WriteLine("Dogs");
            Console.Write("1.Dog Name : ");
            string nn1 = Console.ReadLine();
            Dog d1 = new Dog(nn1);
            Console.Write("2.Dog Name : ");
            string nn2 = Console.ReadLine();
            Dog d2 = new Dog(nn2);
            Console.Clear();

            Console.WriteLine(c1.Greets());
            Console.WriteLine(c1.Greets());

            Console.WriteLine(d1.Greets());
            Console.WriteLine(d1.Greets());

            Console.WriteLine(c1.toString());
            Console.WriteLine(c2.toString());

            Console.WriteLine(d1.toString());
            Console.WriteLine(d2.toString());
            Console.ReadKey();
        }
    }
}
