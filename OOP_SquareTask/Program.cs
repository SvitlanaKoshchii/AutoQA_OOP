using System;

namespace OOP_SquareTask
{
    class Program
    {                
        private static Square square;
        private static Circle circle;
        private static ValidationHelper helper;

        
        static void Main(string[] args)
        {
            helper = new ValidationHelper();
            CheckInputAttempt();



            static void CheckInputAttempt()
            {
                int inputAttempt = 0;
                for (; inputAttempt < Constants.maxAttempt; inputAttempt++)
                {
                    EnterSquareSide();                                        
                }

                if (inputAttempt == Constants.maxAttempt)
                {
                    CreateSquare(GetRandomValue());
                    ShowSquareArea();
                }
            }

            static double GetRandomValue()
            {

                Console.WriteLine(Constants.showAttemptsEnded);

                Random random = new Random();

                double value = random.NextDouble() * (Constants.maxRandomBorder - Constants.minRandomBorder) + Constants.minRandomBorder;
                value = Math.Round(value,2);
                //value = GetRandomValue(value);
                Console.WriteLine("Random radius = {0}", value);

                return value;
            }

            static void EnterSquareSide()
            {
                Console.WriteLine(Constants.enterSquareSide);
      
                string sideInput = Console.ReadLine(); // user input value for side of square
              
                ValidateEnteredValue(sideInput);                

            }

         

            static void ValidateEnteredValue(string value)
            {
                if (helper.IsDouble(value))
                {
                    double side = helper.GetValidatedDouble(value);

                    CreateSquare(side);
                }
                else
                {
                    Console.WriteLine(Constants.showErrorInputValue);
                        
                }
                
              
            }

            static void CreateSquare(double side)
            {
                square = new Square(side); //object square created     
            }

            static void ShowSquareArea()
            {       
                Console.WriteLine(Constants.showSquareArea + "{0}", square.SquareArea);
            }

            static double GetRoundedNumber(double number)
            {
                return Math.Round(number, 2);
            }


           

        }
    }
}
