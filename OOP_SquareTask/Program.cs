using System;

namespace OOP_SquareTask
{
    class Program
    {
        const double pi = 3.14; // pi
        const double minRandomBorder = 0.5; // min random border
        const double maxRandomBorder = 5; // max random border
        private static double roundSquare;

        // public int roundInputAttempt; //user input radius attempt

        static void Main(string[] args)
        {
            CalculateRoundSquare();
            // CalculateSquareArea();

            Program program = new Program();

            static void CalculateRoundSquare()
			{
                Random random = new Random();                
               
                int roundInputAttempt;
                double radius; // result side 

                for (roundInputAttempt = 1; roundInputAttempt < 4; roundInputAttempt++)
                {
                    Console.WriteLine("Enter ROUND radius: ");
                    string radiusInput = Console.ReadLine(); // user input value for radius

                    if (double.TryParse(radiusInput, out radius))
                    {
                        CalculateSquareFormlula(radius);  // round square calculation
                        
                        break;
                    }
                    else if (roundInputAttempt < 3)
                    {
                        Console.WriteLine("Wrong attempt {0}. Please, enter only numbers.", roundInputAttempt);
                            
                    }
                    else
                    {
                        Console.WriteLine("Last attempt is reached. Radius is selected randomly.");

                        radius = random.NextDouble() * (maxRandomBorder - minRandomBorder) + minRandomBorder;
                        radius = GetRoundedNumber(radius);
                        Console.WriteLine("Random radius = {0}", radius);

                        CalculateSquareFormlula(radius);  // round square calculation
                        
                    }
                    
                }
               
            }

            static void CalculateSquareFormlula(double radius)
            {
                double roundSquare = pi * Math.Pow(Math.Round(radius, 2), 2); // round square calculation formula
                roundSquare = GetRoundedNumber(roundSquare);
                Console.WriteLine("ROUND square equals to {0}", roundSquare);  
            }

            static double GetRoundedNumber(double number)
            {
                return Math.Round(number, 2);
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
