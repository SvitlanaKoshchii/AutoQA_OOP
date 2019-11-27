using System;

namespace OOP_SquareTask
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateRoundSquare();
            CalculateSquareArea();

            static void CalculateRoundSquare()
			{
				const double pi = 3.14; // pi 
                double radius; // result side 
                Console.WriteLine("Enter ROUND radius: ");
				string radiusInput = Console.ReadLine(); // user input value for radius
                if (double.TryParse(radiusInput, out radius))
                {
                    double roundSquare = pi * Math.Pow(radius, 2); // round square calculation
                    Console.WriteLine("ROUND square equals to {0}", roundSquare);
                }
                else
                {
                    Console.WriteLine("Enter SQUARE side validation failed");
                }
			}

            static void CalculateSquareArea()
            {

                double side; // result side 
                Console.WriteLine("Enter SQUARE side : ");
                string sideInput = Console.ReadLine(); // user input value for side of square 

                if (double.TryParse(sideInput, out side)) // check if userr input is double
                {
                    double areaOfSquare = Math.Pow(side, 2); // area of square calculation
                    Console.WriteLine("Area of SQAURE  equals to {0}", areaOfSquare);
                }
                else
                {
                    Console.WriteLine("Enter SQUARE side validation failed");
                }
            }

        }
    }
}
