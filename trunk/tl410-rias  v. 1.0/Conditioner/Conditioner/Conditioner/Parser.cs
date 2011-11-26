using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conditioner
{
    class Parser
    {
        private String conditions;
        private string[,] parsedConditions;
        private List<string> findedConditions = new List<string>();

        public Parser(string conditions)
        {
            this.conditions = conditions; //получаем строку условий
            parseConditions();            //парсим строку
        }

        private void parseConditions()
        {
            findConditions();

            parsedConditions = new string[findedConditions.Count, 3];
            int i = 0;
            foreach (string subCondition in findedConditions)
            {
                if ((!subCondition.Equals("&")) && (!subCondition.Equals("|")))
                {
                    parsedConditions[i, 0] = findVeriable(subCondition);
                    parsedConditions[i, 1] = findAction(subCondition);
                    parsedConditions[i, 2] = findValue(subCondition);
                }
                else
                {
                    parsedConditions[i, 0] = subCondition;
                }

                i++;
            }
        }

        private void findConditions()
        {
            int startPosSub = 0;
            for (int i = 0; i < conditions.Length; i++)
            {

                if (conditions[i] == '(')
                {
                    if (conditions[i + 1] != '(')            // если встречаем открывающие скобки, проверяем не идет ли впереди
                    {                                      // еще 1 скобка. Если нет то запоминаем позицию.
                        startPosSub = i;
                    }
                }
                if (conditions[i] == ')')
                {
                    if (conditions[i - 1] != ')')          // если встретили закрывающую скобку и перед ней нету еще 1, то берем
                    {                                      // рание сохранненную позицую и делаем сабстринг, таким образом занося 
                        findedConditions.Add(conditions.Substring(startPosSub + 1, i - startPosSub - 1).ToString());     // условие в список
                    }
                }
                if ((conditions[i] == '|') || (conditions[i] == '&'))  // если встретили один из знаков проверяем нет ли перед ним такого
                {                                                      // же знака, если нету то сохраняем его как условие
                    if ((conditions[i - 1] != '|') && (conditions[i - 1] != '&'))
                    {
                        findedConditions.Add(conditions.Substring(i, 1));
                    }
                }
            }

        }

        public string findVeriable(string expression) // метод отввечающий за поиск переменной в строке
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if(i+1<expression.Length)
                {
                    if ((expression[i + 1] == '>') || (expression[i + 1] == '=') || (expression[i + 1] == '<') || (expression[i + 1] == '!'))
                {
                    return expression.Substring(0, i + 1);
                }
                }
            }
            //hight>5
            return "Veriable Not Found";
        }

        public string findAction(string expression) // метод отвечающий за поиск логического действия в строке
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if (i + 1<expression.Length)
                {
                    if ((expression[i] == '>') || (expression[i] == '=') || (expression[i] == '<') || (expression[i] == '!'))
                    {
                        if (expression[i + 1] == '=')
                        {
                            return expression.Substring(i, 2);
                        }
                        else
                        {
                            return expression.Substring(i, 1);
                        }
                    }
                }
            }

            return "Action Not Found";
        }

        public string findValue(string expression) //метод отвечающий за поиск значения парменной в строке
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if (i + 1<expression.Length)
                {
                    if ((expression[i] == '>') || (expression[i] == '=') || (expression[i + 1] == '<'))
                    {
                        if (expression[i + 1] != '=')
                        {
                            return expression.Substring(i + 1, expression.Length - i-1);
                        }
                    }
                }
            }

            return "Value Not Found";
        }

        public string[,] getParsedConditions()
        {
            return parsedConditions;

        }
    }

}

