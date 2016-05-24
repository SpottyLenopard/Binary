using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest.Classes
{
    class Calc
    {
        int _leftValue;
        int _rightValue;

        public int LeftValue 
        {
            get { return _leftValue; }
            set { _leftValue = value; }
        }

        public int RightValue
        {
            get { return _rightValue; }
            set { _rightValue = value; }
        }

        public int Add()
        {
            return LeftValue + RightValue;
        }

        public int Substract()
        {
            return LeftValue - RightValue;
        }
    }
}
