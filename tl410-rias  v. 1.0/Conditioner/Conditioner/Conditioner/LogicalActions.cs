using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LogicalActions
    {
        public bool moreThen(double permitValue, double resValue)
        {
            return permitValue < resValue;
        }
        public bool lessThen(double permitValue, double resValue)
        {
            return permitValue > resValue;
        }
        public bool moreEqThen(double permitValue, double resValue) 
        {
            return permitValue >= resValue;
        }
        public bool lessEqThen(double permitValue, double resValue) 
        {
            return permitValue <= resValue;
        }
        public bool equalent(double permitValue, double resValue) 
        {
            return permitValue == resValue;
        }
        public bool and(bool firstExpRes, bool secondExpRes)
        {
            return firstExpRes && secondExpRes;
        }
        public bool or(bool firstExpRes, bool secondExpRes)
        {
            return firstExpRes || secondExpRes;
        }
    }
}
