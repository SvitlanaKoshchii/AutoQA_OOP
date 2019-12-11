using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Task3
{
    class Program
    {
        private static CalcHelper calcHelper;
        static void Main(string[] args)
        {
            calcHelper = new CalcHelper();

            calcHelper.GetStartRangeValue();
            calcHelper.GetEndRangeValue();
            calcHelper.PrintArrList();
            calcHelper.CalculateSum();

        }
    }
}
