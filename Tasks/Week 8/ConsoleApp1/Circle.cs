using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle
    {
        protected double radius = 1.0;
        protected string color =  "red";

        public Circle()
        {
            radius = 1.0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius,string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public virtual double getRadius()
        {
            return radius;
        }

        public virtual double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public virtual void setRadius(double radius)
        {
            this.radius = radius;
        }

        public virtual string getColor()
        {
            return color;
        }
        public virtual void setColor(string color)
        {
            this.color = color;
        }
        
        public virtual string toString()
        {
            return "Circle[radius=radius,color=colour";
        }

        public virtual string toString()
        {
            return $"Circle - Radius: {radius}, Color: {color}";


        }
    }
}
