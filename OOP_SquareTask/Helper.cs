using System;
using System.Globalization;

namespace OOP_Task1_2_CircleSquareCalculations
{
    public class Helper
    {

        public double GetValidDoubleValue(string valueType, string figure)
        {
            for (int i = 1; i <= Constants.maxAttempt; i++)
            {
                Console.WriteLine(Constants.showEnterValue, valueType, figure);

                string inputVal = Console.ReadLine().Replace(",", ".");
                bool isDouble = double.TryParse(inputVal, out double result);

                if (isDouble && isPositive(result))
                {
                    return GetRoundedNumber(result);
                }
                else
                {
                    Console.WriteLine(Constants.showErrorInputValue, i, Constants.maxAttempt);
                }
            }
            return GetRandomValue();
        }

        public void showAreaResult(string figure, double result)
        {
            Console.WriteLine(Constants.showAreaResult, figure, GetRoundedNumber(result));
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

        public bool isPositive(double value)
        {
            if (value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void showFiguresPlaceEachOther(double circleArea, double squareArea)
        {
            if (2 * Math.Sqrt(circleArea / Math.PI) <= Math.Sqrt(squareArea))
            {
                Console.WriteLine(Constants.showCirclePlacedSquare);
            }
            else if (2 * Math.Sqrt(circleArea / Math.PI) >= Math.Sqrt(2) * Math.Sqrt(squareArea))
            {
                Console.WriteLine(Constants.showSquarePlacedCircle);
            }
            else Console.WriteLine(Constants.showSquareAndCircleCanNotPlace);

        }

        


        /*public double GetDouble(string enteredSide) //method to check if entered value is double 
        {
            string replacedComa = enteredSide.Replace(",", ".");
            double result;

            // Try parsing in the current culture
            if (!double.TryParse(replacedComa, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                // Then try in US english
                !double.TryParse(replacedComa, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                // Then in neutral language
                !double.TryParse(replacedComa, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                result = Constants.wrongDouble;
            }
            return result;
        }

        public double ReplaceComaToDot(string side) // method to replace coma to dot in user input 
        {
            string replacedComa = side.Replace(",", ".");

            return double.Parse(replacedComa, CultureInfo.InvariantCulture);
        }

        

        public double GetDoubleFromString(string value) // method to retrieve double from entered string
        {
            double parsedDouble = GetDouble(value);

            if (parsedDouble > 0) // check that user did positive input
            {
                return parsedDouble;
            }
            else
            {
                Console.WriteLine(Constants.showErrorInputValue);

                return Constants.wrongDouble;
            }*/
    }

}

