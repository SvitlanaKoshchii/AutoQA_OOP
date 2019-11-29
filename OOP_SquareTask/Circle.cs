using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_SquareTask
{
    class Circle
    {
        public double radius;

        //Consctructor with side parameter
        public Circle(double r)
        {
            radius = r;
        }

        //method calculate area of square 
        public void CalculateSquareArea() { }

        //property Square
        public double Side
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




