using System;
using System.Linq;
using System.Text;

namespace OOP_Task4
{
    class Helper
    {
        private string _initialStr;

        public void GetWord()
        {
            Console.WriteLine(Constants.showEnterWord);
            string inputVal = Console.ReadLine();
            if (!IsWordContainDigit(inputVal))
            {
                _initialStr = inputVal;
                
            }
            else 
            {
                Console.WriteLine(Constants.showWrongWord);
                GetWord();
            }
        }

        public bool IsWordContainDigit(string str)
        {
            bool isDigitPresent = str.Any(c => char.IsDigit(c));
            if (isDigitPresent)
            {
                return true;
            }
            else
            {
                return false;
            }
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
