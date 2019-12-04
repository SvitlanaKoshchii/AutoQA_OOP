using System;
namespace OOP_SquareTask
{
    static class Constants
    {
        public const double minRandomBorder = 0.5; // min random border
        public const double maxRandomBorder = 5; // max random border
        public const double wrongDouble = -1; // if user write not correct value

        public const int roundingNumber = 2; // rounded entered value after point
        public const int maxAttempt = 3; //max invalid attempt

        public const string enterSquareSide = "Enter SQUARE side : ";
        public const string enterCircleRadius = "Enter CIRCLE radius : ";
        public const string showSquareArea = "Square Area = ";
        public const string showCircleArea = "Circle Area = ";
        public const string showErrorInputValue = "Invalid input. Value should be numerical and can contain dot or coma.";
        public const string showAttemptsEnded = "Last attempt is reached. Value is selected randomly.";
    }
}
