using System;

namespace OOP_SquareTask
{
	class Program
	{
		static void Main(string[] args)
		{
			CalculateRoundSquare();
			CalculateAreaOfSquare();

			static void CalculateRoundSquare()
			{
				const double pi = 3.14; // pi 

				Console.WriteLine("Enter ROUND radius: ");
				double radius = Convert.ToDouble(Console.ReadLine()); // radius
				double roundSquare = pi * radius * 2; // round square calculation
				Console.WriteLine("ROUND square equals to {0}", roundSquare);

			}

			static void CalculateAreaOfSquare()
			{

				Console.WriteLine("Enter SQUARE side : ");
				double side = Convert.ToDouble(Console.ReadLine()); // side of square
				double areaOfSquare = side * side; // area of square calculation
				Console.WriteLine("Area of SQAURE  equals to {0}", areaOfSquare);
			}

		}
	}
}
