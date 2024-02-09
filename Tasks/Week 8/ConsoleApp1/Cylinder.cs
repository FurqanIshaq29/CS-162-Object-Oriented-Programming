using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cylinder : Circle
    {
        private double height = 1.0;

        public Cylinder() : base()
        {
            height = 1.0;
        }

        public Cylinder(double radius) : base(radius)
        {
            this.radius = radius;
        }

        public Cylinder(double radius, double height) : base(radius)
        {
            this.radius = radius;
            this.height = height;
        }

        public Cylinder(double radius, double height, string color) : base(radius,color)
        {
            this.radius = radius;
            this.height = height;
            this.color = color;
        }

        public double getHeight(double height)
        {
            return height;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        

        public double getVolume()
        {

            double volume = ((4 / 3 )* (3.1415) * (radius * radius) * (height));
            return volume;
        }
    }
}
