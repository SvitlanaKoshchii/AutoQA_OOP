using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOP_Task3
{
    class MyArray
    {
        private int _startRange;
        private int _endRange;

        //Consctructor 
        public MyArray(int startRange, int endRange)
        {
            _startRange = startRange;
            _endRange = endRange;
        }

        //property for Start Range
        public int StartRange
        {
            get
            {
                return _startRange;
            }
            set
            {
                _startRange = value;            
            }
        }

        //property for End Range
        public int EndRange
        {
            get
            {
                return _endRange;
            }
            set
            {
                _endRange = value;
            }
        }

        //get array list elemets 
        public void GetArrElements()
        {
            ArrayList myList = new ArrayList();
            for (int i = _startRange; i <= _endRange; i++) //end of range is wrong!!!! Need to fix
            {
                myList.Add(i);
            }
        }

    }
}
