using System;
namespace OOP_Task1_2_CircleSquareCalculations
{
    static class Constants
    {
        public const double minRandomBorder = 0.5; // min random border
        public const double maxRandomBorder = 5; // max random border

        //public const double wrongDouble = -1.0; // if user write not correct value

        public const int roundingNumber = 2; // rounded entered value after point
        public const int maxAttempt = 3; //max invalid attempt

        public const string showEnterValue = "Enter {0} of {1}";
        public const string showAreaResult = "Area of {0} equals to: {1}";

        public const string showErrorInputValue = "Invalid input. Value should be numerical, positive and can contain dot or coma. Attempt {0} of {1}";
        public const string showAttemptsEnded = "Last attempt is reached. Value is selected randomly.";

        //public const string enterSquareSide = "Enter SQUARE side : ";
        //public const string enterCircleRadius = "Enter CIRCLE radius : ";
        //public const string showSquareArea = "Square Area = ";
        //public const string showCircleArea = "Circle Area = ";      

        public const string showSquarePlacedCircle = "SQUARE is placed in CIRCLE. CIRCLE can't be places in SQUARE";

        //public const string showSquareNotPlacedCircle = "SQUARE is NOT placed in the CIRCLE.";

        public const string showCirclePlacedSquare = "CIRCLE is placed in the SQUARE. SQUARE can't be placed in CIRCLE";
        //public const string showCircleNotPlacedSquare = "CIRCLE is NOT placed in SQUARE.";

        public const string showSquareAndCircleCanNotPlace = "Neither SQUARE can place in CIRCLE nor CIRCLE can place in SQUARE";
    }
}
