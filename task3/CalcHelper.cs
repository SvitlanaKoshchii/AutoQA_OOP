using System;
using System.Collections;

namespace OOP_Task3
{
    class CalcHelper
    {
        private int _startRange;
        private int _endRange;
        ArrayList myList = new ArrayList();

        public void GetStartRangeValue()
        {
            //set start range
            Console.WriteLine(Constants.showEnterStartRange);
            string startVal = Console.ReadLine();
            if (IsInt(startVal))
            {
                _startRange = GetNumericFromString(startVal);
            }
            else
            {
                Console.WriteLine(Constants.showInvalidInput);
                GetStartRangeValue();
            }           
        }

        public void GetEndRangeValue()
        {
            //set end range
            Console.WriteLine(Constants.showEnterEndRange);
            string endVal = Console.ReadLine(); 
            
            if (GetRangeBetweenValues(GetNumericFromString(endVal), _startRange) > Constants.minContOfArrayItems)
            {
                _endRange = GetNumericFromString(endVal);
            }
            else
            {
                Console.WriteLine(Constants.showEndRangeError);
                GetEndRangeValue();
            }           
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
                Console.WriteLine(i + " ");
            }
        }

        public void CalculateSum()
        {
            //count sum 
            int sum = 0;
            
                foreach (int i in GetArrList())
                {
                    if (i % 3 == 0 && i % 5 != 0)
                    {
                        sum = sum + i;
                    }
                }
                Console.WriteLine(Constants.showSum, sum);
           
           
            Console.ReadKey();
        }

        public int GetNumericFromString(string value)
        {
            if (Int32.TryParse(value, out int result))
            {
                if (result > 0)
                {
                    return result;
                }     
            }
            
            return result;
        }

        public bool IsInt(string value)
        {
            if (GetNumericFromString(value) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetRangeBetweenValues(int end, int start)
        {
            return end - start;
        }

    }
}
