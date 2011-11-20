using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceFoSimulator
{
    class Container
    {
        public List<String> listEv;
        public List<String> listFac;
        public List<String> listCon;
        public List<String> listOp;

        public Container()
        {
            listEv = new List<string>();
            listFac = new List<string>();
            listCon = new List<string>();
            listOp = new List<string>();

            // заполнение данными
            SetListEvents();
            SetListFactors();
            SetListCondition();
            SetListOp();
        }

        private void SetListEvents()
        {
            // заполения списка событий
            listEv.Add("Отказ левого двигателя");
            listEv.Add("Отказ правого двигателя");
            listEv.Add("Отказ системы управления");
            listEv.Add("Отказ системы охлаждения двигателей");
            listEv.Add("Отказ срабатываня шасси");
            listEv.Add("Турбулентность");
            listEv.Add("Отказ датчика высоты");
            listEv.Add("Отказ датчика скорости");
            listEv.Add("Терорист на самолете");
        }

        private void SetListFactors()
        {
            // заполнение списка факторов
            listFac.Add("Время (мин)");
            listFac.Add("Высота (м)");
            listFac.Add("Далность (км)");
        }

        private void SetListCondition()
        {
            // заполнение списка умов
            listCon.Add("и");
            listCon.Add("или");
            listCon.Add("не");
        }

        private void SetListOp()
        {
            // заполнение списка операторов
            listOp.Add("=");
            listOp.Add(">");
            listOp.Add(">=");
            listOp.Add("<");
            listOp.Add("<=");
            listOp.Add("!=");
        }
        

        public List<String> GetListEvents()
        {
            return listEv;
        }
        public List<String> GetListFactors()
        {
            return listFac;
        }
        public List<String> GetListCondition()
        {
            return listCon;
        }
        public List<String> GetListOp()
        {
            return listOp;
        }

            
    }
}
