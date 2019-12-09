using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Task3
{
    class Program
    {
        private static MyArray array;
        static void Main(string[] args)
        {
            EnterArrayRange(array.StartRange, array.EndRange); //null reference exception for now

            static void EnterArrayRange(out int startValue, out int endValue) 
            {
  
                Console.WriteLine(Constants.showEnterStartRange);
                startValue = Int32.Parse(Console.ReadLine());

                Console.WriteLine(Constants.showEnterEndRange);
                endValue = Int32.Parse(Console.ReadLine());

            }

            static void ShowArray ()
            {
                array.GetArrElements();
                Console.WriteLine(array.);
            }

            static int CountSumOfArrayItems()
            {
                int sum = 0;


                return sum;
            }

            //works w/o methods different classes
            ArrayList myList = new ArrayList();

            int rangeStart;
            int rangeEnd;
            int sum = 0;

            //set start of array
            Console.WriteLine("Enter a start of range");
            rangeStart = Int32.Parse(Console.ReadLine());

            //set end of array
            Console.WriteLine("Enter a end of range");
            rangeEnd = Int32.Parse(Console.ReadLine());

            //add elements to array depending on start and end range value
            for (int i = rangeStart; i <= rangeEnd; i++) //end of range is wrong!!!!
            {
                myList.Add(i);
            }

            // Displaying the elements in ArrayList 
            Console.WriteLine("View the array elements:");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            //count sum (currentry does not includes last element of array. Need to fix)
            if (myList.Count > Constants.minContOfArrayItems)
            {
                foreach (int i in myList)
                {
                    if (i % 3 == 0 && i % 5 != 0)
                    {
                        sum = sum + i;

                    }
                }
                Console.WriteLine("Sum is {0}", sum);
            }
            else
            {
                Console.WriteLine(Constants.showCanNotCountSum);
            }
            Console.ReadKey();

        }
    }
}
