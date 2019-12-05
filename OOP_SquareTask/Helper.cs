﻿using System;
using System.Globalization;

namespace OOP_Task1_2_CircleSquareCalculations
{
    public class Helper
    {
        public double GetDouble(string enteredSide) //method to check if entered value is double 
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
                result = GetRoundedNumber(Constants.wrongDouble); // because if not use rounded method, double with a lot with 0 and other numbers after dot and != -1
            }
            return result;
        }

        public double ReplaceComaToDot(string side) // method to replace coma to dot in user input 
        {           
            string replacedComa = side.Replace(",", ".");

            return double.Parse(replacedComa, CultureInfo.InvariantCulture);
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
            double parsedDouble = GetDouble(value);

            if (parsedDouble != Constants.wrongDouble)
            {
                if (parsedDouble > 0) // check that user did positiva input
                {
                    return parsedDouble;
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
