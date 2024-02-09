using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prices = new List<int>();
            int a = 0;
            while (a != 8)
            {
                Console.WriteLine("Enter number " + (a + 1) + " : ");
                int b = int.Parse(Console.ReadLine());
                prices.Add(b);
                a++;
            }

           prices.Sort();
           // List<int> Name = prices.OrderBy(c => prices).ToList();
            foreach(int n in prices)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();

        }
    }
}
