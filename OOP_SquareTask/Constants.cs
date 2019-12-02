using System;
namespace OOP_SquareTask
{
    static class Constants
    {
        public const double minRandomBorder = 0.5; // min random border
        public const double maxRandomBorder = 5; // max random border

        public const int roundingNumber = 2; // rounded entered value after point
        public const int maxAttempt = 3; //max invalid attempt

        public const string enterSquareSide = "Enter SQUARE side : ";
        public const string enterCircleRadius = "Enter CIRCLE radius : ";
        public const string showSquareArea = "Square Area = ";
        public const string showErrorInputValue = "Invalid input. Please, enter number which can contain dot or coma.";
        public const string showAttemptsEnded = "Last attempt is reached. Radius is selected randomly.";
    }
}
