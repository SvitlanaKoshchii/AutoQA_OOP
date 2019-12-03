﻿using System;

namespace OOP_SquareTask
{
    class Circle
    {
        private double _radius;

        //Consctructor with radius parameter
        public Circle(double radius)
        {
            _radius = radius;
        }

        //property Radius
        public double Radius
        {
            get
            {
                return _radius;
            }
        }

        //property CircleArea to calculate area of circle
        public double CircleArea
        {
            get
            {
                return Math.Pow(_radius, 2) * Math.PI;
            }
        }
    }
}
