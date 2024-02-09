using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    class Program
    {
        class circle
        {
            public double radius;
            public circle(double r)
            {
                this.radius = r;
            }
            public double getArea(double radius)
            {
                double answer = (Math.PI * (radius * radius));
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius : ");
            double r = double.Parse(Console.ReadLine());
            circle area = new circle(r);
            double answer = area.getArea(r);
            Console.WriteLine("Answer = " + answer);
            Console.ReadKey();
        }
    }
}
