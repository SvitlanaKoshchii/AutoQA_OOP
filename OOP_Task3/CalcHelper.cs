using System;
using System.Collections;

namespace OOP_Task3
{
    class CalcHelper
    {
        private int _startRange;
        private int _endRange;
        ArrayList myList = new ArrayList();

        public void GetRangeValues()
        {
            //set start range
            Console.WriteLine(Constants.showEnterStartRange);
            string startVal = Console.ReadLine();
            bool isStartNumerical = int.TryParse(startVal, out _startRange);

            //set end range
            Console.WriteLine(Constants.showEnterEndRange);
            string endVal = Console.ReadLine();
            bool isEndNumerical = int.TryParse(endVal, out _endRange);
        }

        public ArrayList GetArrList()
        {
            //add elements to array depending on start and end range value
            ArrayList myList = new ArrayList();
            for (int i = _startRange; i <= _endRange; i++) //end of range is wrong!!!!
            {
                myList.Add(i);
            }
            return myList;
        }

        public void PrintArrList()
        {
            // Displaying the elements in ArrayList 
            Console.WriteLine("View the array elements:");
            foreach (int i in GetArrList())
            {
                Console.WriteLine(i);
            }
        }

        public void CalculateSum()
        {
            //count sum 
            int sum = 0;
            if (GetArrList().Count > Constants.minContOfArrayItems)
            {
                foreach (int i in GetArrList())
                {
                    if (i % 3 == 0 && i % 5 != 0)
                    {
                        sum = sum + i;
                    }
                }
                Console.WriteLine(Constants.showSum, sum);
            }
            else
            {
                Console.WriteLine(Constants.showCanNotCountSum);
            }
            Console.ReadKey();
        }

    }
}
