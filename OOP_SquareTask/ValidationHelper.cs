using System;
namespace OOP_SquareTask
{
    public class ValidationHelper
    {
        public ValidationHelper()
        {
        }

        public bool IsDouble(string enteredSide)
        {
            if (double.TryParse(enteredSide, out double side)) // check if userr input is double
            {
                return true;
            }

            return false;
        }

        public double GetValidatedDouble(string side) // method to replace come to dom in user input
        {
            return double.Parse(side.Replace(",", "."));
        }

    }
}
