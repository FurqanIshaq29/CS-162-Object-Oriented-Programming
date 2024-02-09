using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_and_For_each_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            forEachWithNoDataType();
        }

        static void forLoop()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.Read();
        }

        static void forEachLoop()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }

        static void forEachWithNoDataType()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
