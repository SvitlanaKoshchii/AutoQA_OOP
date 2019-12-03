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
        }

        //property CircleArea to calculate area of circle
        public double CircleArea
        {
            get
            {
                return Math.Pow(radius, 2) * Math.PI;
            }
        }
    }
}
