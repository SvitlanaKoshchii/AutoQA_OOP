using System;

namespace OOP_Task1_2_CircleSquareCalculations
{
    class Program
    {
        private static Square square;
        private static Circle circle;
        private static Helper helper;

        static void Main(string[] args)
        {
            helper = new Helper();

            Square square = new Square(helper.GetValidDoubleValue(Constants.side, Constants.squareFigure));
            helper.showAreaResult(Constants.squareFigure, square.SquareArea);

            Circle circle = new Circle(helper.GetValidDoubleValue(Constants.radius, Constants.circleFigure));
            helper.showAreaResult(Constants.circleFigure, circle.CircleArea);

            helper.showFiguresPlaceEachOther(circle.CircleArea, square.SquareArea);
           
        }
    }
}

