using System;

namespace OOP_Task4
{
    class Program
    {
        private static Helper helper;

        static void Main(string[] args)
        {
            helper = new Helper();

            helper.GetWord();
            helper.ShowResult();
        }
    }
}
