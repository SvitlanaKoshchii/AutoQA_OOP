using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
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

            
           /* static void EnterArrayRange()
            {
                int rangeStart;
                int rangeEnd;

                //set start of array
                Console.WriteLine("Enter a start of range");
                rangeStart = Int32.Parse(Console.ReadLine());

                //set end of array
                Console.WriteLine("Enter a end of range");
                rangeEnd = Int32.Parse(Console.ReadLine());
            }*/

            //add elements to array depending on start and end range value
            for (int i = rangeStart; i <= rangeEnd; i++) //end of range is wrong!!!! Need to fix
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
            if (myList.Count > 10)
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
                Console.WriteLine("Can not count sum. Array length is less than 10 items");
            }
            Console.ReadKey();

        }
    }
}
