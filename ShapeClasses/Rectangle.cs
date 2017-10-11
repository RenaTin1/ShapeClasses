using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Rectangle : Shape
    {
        private double length; //class member
        private double width;

        public double Length //property
        {
            set { length = value; }
            get { return length; }
        }
        public double Width//property
        {
            set { width = value; }
            get { return width; }
        }

        public Rectangle() //constructors
        {   Length= 0;
            Width = 0;
        }


        public Rectangle(double w, double l)
        {
            Length = l;
            Width = w;
        }


        public override void Draw()
        {

            Console.WriteLine("Draw a Rectangle!");
        }

        public override double GetArea()
        {
            return Length* Width;
        }









    }
}
