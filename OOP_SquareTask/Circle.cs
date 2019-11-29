using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_SquareTask
{
    class Circle
    {
        public double radius;

        //Consctructor with radius parameter
        public Circle(double r)
        {
            radius = r;
        }

        //method calculate area of circle 
        public void CalculateCircleArea() { }

        //property RAdius
        public double Radius
        {
            get
            {
                return radius;
            }

            set // add validatation that input value for radius is double
            {
                radius = value;
            }
        }
    }
}




