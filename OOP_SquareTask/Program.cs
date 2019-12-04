using System;

namespace OOP_SquareTask
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

                if (helper.GetDoubleFromString(sideInput) != Constants.wrongDouble)
                {
                    double validValue = helper.GetValidatedDouble(sideInput);

                    CreateSquare(helper.GetRoundedNumber(validValue));
                }               
            }

            static void EnterCircleRadius() // method where user inputs value for circle radius 
            {
                Console.WriteLine(Constants.enterCircleRadius);

                string radiusInput = Console.ReadLine(); // user input value for raduis of circle
             
                if (helper.GetDoubleFromString(radiusInput) != Constants.wrongDouble)
                {
                    double validValue = helper.GetValidatedDouble(radiusInput);

                    CreateCirle(helper.GetRoundedNumber(validValue));
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
        }
    }
}
