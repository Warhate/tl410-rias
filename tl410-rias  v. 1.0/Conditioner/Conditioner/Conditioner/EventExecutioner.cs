using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conditioner
{
    class EventExecutioner
    {

        /* в следующей версии будет реализована связь с приемником.
         * а пока всем данным значения будут присвоены в этом классе
         */
        int cur_hight = 500;
        int cur_time = 15;
        int cur_distance = 1000;

        private string[] subConditionsResult;
        private string[,] parsedConditions;
        
        public EventExecutioner(string eventCondition, int cur_hight, int cur_time, int cur_distance)
        {
            this.cur_hight = cur_hight;
            this.cur_distance = cur_distance;
            this.cur_time = cur_time;
            Parser _parser = new Parser(eventCondition);
            this.parsedConditions = _parser.getParsedConditions();
        }

        public bool checkEventState()
        {

            return false;
        }
        public bool executeEvent()
        {
            subConditionsResult = new string[parsedConditions.GetLength(0)];
            for(int i=0;i<parsedConditions.GetLength(0);i++)
            {
                if ((!parsedConditions[i, 0].Equals("&")) && (!parsedConditions[i, 0].Equals("|")))
                {
                    string res =parsedConditions[i, 1].ToString();
                    subConditionsResult[i] = Convert.ToString(executeSubCondition(getVariableCurrentValue(parsedConditions[i, 0]), Convert.ToInt32(parsedConditions[i, 2]), parsedConditions[i, 1].ToString()));
                }
                else
                {
                    subConditionsResult[i] = parsedConditions[i, 0];
                }
            }
            bool totalResult;
            if (subConditionsResult.Length > 1)
            {
                totalResult = externalLogicExecute(subConditionsResult[0],subConditionsResult[2], subConditionsResult[1]);
                for (int i = 3; i < subConditionsResult.Length; i+=2)
                {
                    totalResult = externalLogicExecute(totalResult.ToString(), subConditionsResult[i + 1], subConditionsResult[i]);

                }
                return totalResult;
            }
            else
            {
                return Convert.ToBoolean(subConditionsResult[0]);
            }

            /*
            if(subConditionsResult.Length>1)
            {
                int i=0;
                while (subConditionsResult[i])
                {
                
                }
            }*/
 
        }
        
        private bool externalLogicExecute(string expression1, string expression2, string actionType)
        {
            if (actionType.Equals("&"))
            {
                return LogicalActions.and(Convert.ToBoolean(expression1), Convert.ToBoolean(expression2));
            }
            else
            {
                return LogicalActions.or(Convert.ToBoolean(expression1), Convert.ToBoolean(expression2));
            }
        }
        private bool executeSubCondition(int currentValue, int permitedValue, string actionType)
        {
            bool res;
            switch (actionType)
            {
                case ">":
                    return LogicalActions.moreThen(permitedValue, currentValue);
                case ">=" :
                    return LogicalActions.moreEqThen(permitedValue, currentValue);
                case "<":
                    return LogicalActions.lessThen(permitedValue, currentValue);
                case "<=":
                    return LogicalActions.lessEqThen(permitedValue, currentValue);
                case "==":
                    return LogicalActions.equalent(permitedValue, currentValue);
                case "!=":
                    return LogicalActions.notEqualent(permitedValue, currentValue);
                default:
                    return false;
            }
        }
        private int getVariableCurrentValue(string variableName)
        {
            switch (variableName)
            {
                case "hight": 
                    return cur_hight;
                case "distance":
                    return cur_distance;
                case "time":
                    return cur_time;
                default: return 0;

            }
        }

    }
}
