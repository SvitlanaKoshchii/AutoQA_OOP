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

            CheckInputSquareAttempt();
            Console.WriteLine();
            CheckInputCircleAttempt();

            Console.WriteLine();
            CheckSquarePlacedCircle();
            CheckCirclePlacedSquare();

            static void CheckInputSquareAttempt() //check inputed attempt for Square
            {
                int inputAttempt = 0;

                for (; inputAttempt < Constants.maxAttempt; inputAttempt++)
                {
                    EnterSquareSide();

                    if (square != null)
                    {
                        break;
                    }
                }

                if (inputAttempt == Constants.maxAttempt)
                {
                    CreateSquare(helper.GetRandomValue());
                }

                ShowSquareArea();
            }

            static void CheckInputCircleAttempt() //check inputed attempt for Circle
            {
                int inputAttempt = 0;

                for (; inputAttempt < Constants.maxAttempt; inputAttempt++)
                {
                    EnterCircleRadius();

                    if (circle != null)
                    {
                        break;
                    }
                }

                if (inputAttempt == Constants.maxAttempt)
                {
                    CreateCirle(helper.GetRandomValue());
                }

                ShowCircleArea();
            }

            static void EnterSquareSide() // method where user inputs value for square side
            {
                Console.WriteLine(Constants.enterSquareSide);

                string sideInput = Console.ReadLine(); // user input value for side of square

                double inputDouble = helper.GetDoubleFromString(sideInput);

                if(inputDouble != Constants.wrongDouble) // check if input value is double what we need              
                {                    
                    CreateSquare(helper.GetRoundedNumber(inputDouble));
                }
            }

            static void EnterCircleRadius() // method where user inputs value for circle radius 
            {
                Console.WriteLine(Constants.enterCircleRadius);

                string radiusInput = Console.ReadLine(); // user input value for raduis of circle

                double inputDouble = helper.GetDoubleFromString(radiusInput);

                if (inputDouble != Constants.wrongDouble) // check if input value is double what we need    
                {    
                    CreateCirle(helper.GetRoundedNumber(inputDouble));
                }
            }

            static void CreateSquare(double side)
            {
                square = new Square(side); //object square created     
            }

            static void CreateCirle(double radius)
            {
                circle = new Circle(radius); //object circle created     
            }

            static void ShowSquareArea() //display result of square area
            {
                Console.WriteLine(Constants.showSquareArea + "{0}", helper.GetRoundedNumber(square.SquareArea));
            }

            static void ShowCircleArea() //display result of circle area
            {
                Console.WriteLine(Constants.showCircleArea + "{0}", helper.GetRoundedNumber(circle.CircleArea));
            }

            static void CheckSquarePlacedCircle() //check if square placed the circle
            {
                if (circle.Radius <= square.Side/ Math.Sqrt(2))
                {
                    Console.WriteLine(Constants.showSquarePlacedCircle);
                }
                else if (square.SquareDiagonal < circle.CircleDiameter)
                {
                    Console.WriteLine(Constants.showSquareLessCircle);
                }
                else
                {
                    Console.WriteLine(Constants.showSquareNotPlacedCircle);
                }
            }

            static void CheckCirclePlacedSquare() //check if circle placed the square
            {
                if (2*square.Side >= circle.Radius)
                {
                    Console.WriteLine(Constants.showCirclePlacedSquare);
                }
                else if (circle.CircleDiameter < square.Side)
                {
                    Console.WriteLine(Constants.showCircleLessSquare);
                }
                else
                {
                    Console.WriteLine(Constants.showCircleNotPlacedSquare);
                }
            }
        }
    }
}
