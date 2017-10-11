using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    abstract class Shape //use keyword "abstract" to make class as an abstract class
    {
        //all abstract methods are virtual
        public abstract void Draw(); //also use keyword "abstract" for abstract methods

        public abstract double GetArea();

        public override string ToString()
        {
            return "The area of this shape is:" + GetArea();
        }




    }
}
