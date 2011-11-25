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
        
        public EventExecutioner(string eventCondition)
        {
            Parser _parser = new Parser(eventCondition);
            this.parsedConditions = _parser.getParsedConditions();
        }

        public bool checkEventState()
        {

            return false;
        }
        private bool executeEvent()
        {
            for(int i=0;i<parsedConditions.GetLength(0);i++)
            {
                if ((parsedConditions[i, 0] != "&") && (parsedConditions[i, 0] != "|"))
                {
                    subConditionsResult[i] = executeSubCondition(getVariableCurrentValue(parsedConditions[i, 0]), Convert.ToInt32(parsedConditions[i, 2]), parsedConditions[i, 1]).ToString();
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
            switch (actionType)
            {
                case ">": 
                    return LogicalActions.moreThen(currentValue, permitedValue);
                case ">=" :
                    return LogicalActions.moreEqThen(currentValue, permitedValue);
                case "<":
                    return LogicalActions.lessThen(currentValue, permitedValue);
                case "<=":
                    return LogicalActions.lessEqThen(currentValue, permitedValue);
                case "==":
                    return LogicalActions.equalent(currentValue, permitedValue);
                case "!=":
                    return LogicalActions.notEqualent(currentValue, permitedValue);
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
