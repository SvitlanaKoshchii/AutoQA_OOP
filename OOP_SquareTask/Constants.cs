using System;
namespace OOP_Task1_2_CircleSquareCalculations
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

        public const string showSquarePlacedCircle = "Square is placed in Circle and touches the borders.";
        public const string showSquareLessCircle = "Square is placed in Circle and doesn't touch the borders.";
        public const string showSquareNotPlacedCircle = "The Square is NOT placed in the Circle.";

        public const string showCirclePlacedSquare = "Circle is placed in the Square and touches the borders.";
        public const string showCircleLessSquare = "Circle is placed in Square and doesn't touch the borders.";
        public const string showCircleNotPlacedSquare = "Circle is NOT placed in Square.";
    }
}
