using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conditioner
{
    class Parser
    {
        private String conditions;
        private int condtionsNesting;
        private int currentNesting = 0;
        private int [] [] subMass;
        //private string [][] parsedConditions;
        private List<string> findedCondions = new List<string>();
        private Dictionary<string, string[][]> parsedConditions = new Dictionary<string, string[][]>();
        
        public Parser(string conditions)
        {
            this.conditions = conditions; //получаем строку условий
            parseConditions();            //парсим строку


            findConditions();
        }

        private void parseConditions() 
        {
            
            for (int i = 0; i < conditions.Length;i++)
            {
                /*switch (conditions[i])
                {
                    case '(': 
                        currentNesting++;
                        break;
                    case 
                }*/
            }

        }

        private void findConditions()
        {
            int startPosSub = 0;
            for (int i = 0; i < conditions.Length; i++)
            {

                if (conditions[i]=='(')
                {
                    if (conditions[i+1] != '(')            // если встречаем открывающие скобки, проверяем не идет ли впереди
                    {                                      // еще 1 скобка. Если нет то запоминаем позицию.
                        startPosSub = i; 
                    }
                }
                if (conditions[i] == ')')
                {
                    if (conditions[i - 1] != ')')          // если встретили закрывающую скобку и перед ней нету еще 1, то берем
                    {                                      // рание сохранненную позицую и делаем сабстринг, таким образом занося 
                        findedCondions.Add(conditions.Substring(startPosSub+1, i- startPosSub-1 ).ToString());     // условие в список
                    }
                }
                if ((conditions[i] == '|') || (conditions[i] == '&'))  // если встретили один из знаков проверяем нет ли перед ним такого
                {                                                      // же знака, если нету то сохраняем его как условие
                    if((conditions[i-1] != '|') && (conditions[i-1] != '&'))
                    {
                    findedCondions.Add(conditions.Substring(i,1));
                    }
                }/*
                if (conditions[i] == '=')
                {

                }
                if (conditions[i] == '!')
                {

                }
                if ((conditions[i] == '<') || (conditions[i] == '>'))
                {

                }
                else 
                {
 
                }*/
            }
                
           }

        public List<string> getList()
        {
            return findedCondions;

        } 
        }

   }

