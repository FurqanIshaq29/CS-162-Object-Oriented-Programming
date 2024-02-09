using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(1.0,3.0);
            Cylinder c3 = new Cylinder(1.0,4.0);
            c1.setHeight = 3.0;
            c2.setHeight = 4.0;
            c3.setHeight = 5.0;

        }
    }
}
