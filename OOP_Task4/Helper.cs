using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task4
{
    class Helper
    {
        private string _initialStr;
        private string _resultSrt;

        public void GetWord()
        {
            Console.WriteLine(Constants.showEnterWord);
            string inputVal = Console.ReadLine();
            _initialStr = inputVal;
        }

        public string ReverseWord(string _initialStr)
        {
            StringBuilder sb = new StringBuilder(_initialStr.Length);
            for (int i = _initialStr.Length; i-- != 0;)
            {
                sb.Append(_initialStr[i]); 
            }
           
            return sb.ToString();            
        }

        public void ShowResult()
        {
            if (_initialStr == ReverseWord(_initialStr))
            {
                Console.WriteLine(Constants.showWordIsPalindrome, _initialStr);
            }
            else 
            {
                Console.WriteLine(Constants.showWordNotPalindrome, _initialStr);
            }
        
        }

    }
}
