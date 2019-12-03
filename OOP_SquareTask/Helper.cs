using System;
namespace OOP_SquareTask
{
    public class Helper
    {
        public bool IsDouble(string enteredSide)
        {
            if (double.TryParse(enteredSide, out double side)) // check if user input is double
            {
                return true;
            }

            return false;
        }

        public double GetValidatedDouble(string side) // method to replace come to dom in user input
        {
            return double.Parse(side.Replace(",", "."));
        }

        public double GetRoundedNumber(double number)
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

        public double GetDoubleFromString(string value)
        {
            if (IsDouble(value))
            {
                double roundedValue = GetValidatedDouble(value);

                return roundedValue;
            }
            else
            {
                Console.WriteLine(Constants.showErrorInputValue);

                return Constants.wrongDouble;
            }            
        }
    }
}
