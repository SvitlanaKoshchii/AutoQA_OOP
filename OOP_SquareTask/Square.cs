using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_SquareTask
{
    class Square
    {
        public double side;

        //Consctructor with side parameter
        public Square(double s)
        {
            side = s;
        }

        //method calculate area of square 
        public void CalculateSquareArea() { }

        //property Square
        public double Side
        {
            get
            {
                return side;
            }

            set // add validatation that input value for side is double
            {
                side = value;
            }
        }
    }
}


