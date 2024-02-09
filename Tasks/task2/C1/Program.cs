using System;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int length = 7;
            int width = 8;
            for (int i = -5; i < x; i++)
            {
                Console.WriteLine("Hello World");
                int area = length * width;
                Console.WriteLine("Area : " + area);
            }
            Console.ReadKey();

        }
    }
}
