using System;
using System.Globalization;

namespace OOP_Task1_2_CircleSquareCalculations
{
    public class Helper
    {

        public double GetValidDoubleValue(string valueType, string figure) //method to check if entered value valid
        {
            for (int i = 1; i <= Constants.maxAttempt; i++)
            {
                Console.WriteLine(Constants.showEnterValue, valueType, figure);

                string inputVal = Console.ReadLine();
                bool isDouble = IsDouble(inputVal);
                double value = GetLocaleDoubleFromString(inputVal);

                if (isDouble && isPositive(value))
                {
                    return GetRoundedNumber(value);
                }
                else
                {
                    Console.WriteLine(Constants.showErrorInputValue, i, Constants.maxAttempt);
                }
            }

            return GetRandomValue();
        }

        public bool IsDouble(string inputValue)
        {
            if (double.TryParse(inputValue, out double result))
            {
                return true;
            }

            return false;
        }

        public void showAreaResult(string figure, double result) //methor to show results for calculated figure area
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

        public bool isPositive(double value) //method to check if value positive
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

        public void showFiguresPlaceEachOther(double circleArea, double squareArea) //method to check if circle can be placed in square and vice versa
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

        public double GetLocaleDoubleFromString(string value) //method to check if entered value is double 
        {
            string replacedComa = value.Replace(",", ".");
            double result;

            // Try parsing in the current culture
            if (!double.TryParse(replacedComa, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                // Then try in US english
                !double.TryParse(replacedComa, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                // Then in neutral language
                !double.TryParse(replacedComa, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                return Constants.zero;
            }

            return result;
        }

    }
}

