using System;

namespace OOP_Task1_2_CircleSquareCalculations
{
    class Square
    {
        private double _side;
       
        //Consctructor with side parameter
        public Square(double side)
        {
            _side = side;
        }

        //property Side
        public double Side
        {
            get
            {
                return _side;
            }
        }

        //property SuqareArea to calculate area of square
        public double SquareArea
        {
            get
            {
                return Math.Pow(_side, 2);
            }
        }

        //property SquareDiagonal to calculate diagonal of square
        public double SquareDiagonal
        {
            get 
            { 
                    return _side* Math.Sqrt(2);
            }
        }
        
    }
}


