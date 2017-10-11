using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    //if you inherit from a abstract class, you must make this class abstract or use code
    class Circle : Shape
    {
        private double radius; //class member

        public double Radius //property
        {
            set { radius = value; }
            get { return radius; }
        }

        public Circle() //constructors
        { Radius = 0; }


        public Circle(double r)
        {
            Radius = r;
        }


        public override void Draw()
        {

            Console.WriteLine("Draw a circle!");
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }



    }
}
