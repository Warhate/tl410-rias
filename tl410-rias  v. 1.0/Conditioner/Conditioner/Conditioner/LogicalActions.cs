using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conditioner
{
    class LogicalActions
    {
        public static bool moreThen(double permitValue, double resValue)
        {
            bool res = permitValue < resValue;
            return res;
        }
        public static bool lessThen(double permitValue, double resValue)
        {
            return permitValue > resValue;
        }
        public static bool moreEqThen(double permitValue, double resValue) 
        {
            return permitValue >= resValue;
        }
        public static bool lessEqThen(double permitValue, double resValue) 
        {
            return permitValue <= resValue;
        }
        public static bool equalent(double permitValue, double resValue) 
        {
            return permitValue == resValue;
        }
        public static bool and(bool firstExpRes, bool secondExpRes)
        {
            return firstExpRes && secondExpRes;
        }
        public static bool or(bool firstExpRes, bool secondExpRes)
        {
            return firstExpRes || secondExpRes;
        }
        public static bool notEqualent(double permitValue, double resValue)
        {
            return permitValue != resValue;
        }
    }
}
