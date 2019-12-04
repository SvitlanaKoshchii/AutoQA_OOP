using System;
namespace OOP_Task1_2_CircleSquareCalculations
{
    public class Helper
    {
        public bool IsDouble(string enteredSide) //method to check if entered value is double 
        {
            if (double.TryParse(enteredSide, out double side)) // check if user input is double
            {
                return true;
            }

            return false;
        }

        public double ReplaceComaToDot(string side) // method to replace coma to dot in user input
        {
            return double.Parse(side.Replace(",", "."));
        }

        public double GetRoundedNumber(double number) //method to round value up to specific to the particular number of fractional digits
        {
            return Math.Round(number, Constants.roundingNumber);
        }

        public double GetRandomValue() // generate randon value instead of user input
        {
            Console.WriteLine(Constants.showAttemptsEnded);

            Random random = new Random();

            double value = random.NextDouble() * (Constants.maxRandomBorder - Constants.minRandomBorder) + Constants.minRandomBorder;
            value = GetRoundedNumber(value);

            Console.WriteLine("Random value = {0}", value);

            return value;
        }

        public double GetDoubleFromString(string value) // method to retrieve double from entered string
        {
            if (IsDouble(value))
            {                
                double validDouble = ReplaceComaToDot(value);

                if (validDouble > 0) //check for positive input
                {
                    return validDouble;
                }
                
                Console.WriteLine(Constants.showErrorPositiveNumber);

                return Constants.wrongDouble;                
            }
            else
            {
                Console.WriteLine(Constants.showErrorInputValue); //message value is not double

                return Constants.wrongDouble;
            }            
        }
    }
}
