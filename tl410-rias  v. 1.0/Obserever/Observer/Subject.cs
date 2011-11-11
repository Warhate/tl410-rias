using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        
        }

        public void Dettach(Observer observer)
        {
            _observers.Remove(observer);
        
        }

        public void Notify()
        {
            foreach (Observer obs in _observers)
            {

                obs.Update();
            }
        
        }

    }

    public enum EqualState
    {
        /// <summary>
        /// Равно
        /// </summary>
        Equally =0,
        
        /// <summary>
        /// Больше
        /// </summary>
        Over,

        /// <summary>
        /// Меньше
        /// </summary>
        Under,
        /// <summary>
        /// Неравно (если нелья определить больше или меньше)
        /// </summary>
        NotEqually

    }


    /// <summary>
    /// Класс состояния ЛА
    /// </summary>
    public class State:Subject
    {
        /// <summary>
        /// Список параметров
        /// </summary>
        private SortedList<String, String> _parameters;




        public State()
        {
            Parameters = new SortedList<string, string>();

        }

        /// <summary>
        /// Список параметров
        /// </summary>
        public SortedList<string, string> Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }


        /// <summary>
        /// Добавляет параметр и его значение
        /// </summary>
        /// <param name="name">Название параметра</param>
        /// <param name="value">Значение</param>
        /// <returns>Успешность добавления</returns>
        public bool AddParam(String name, String value)
        {

            if(Parameters.ContainsKey(name))
            {
                return false;
            }

            Parameters.Add(name, value);

            return true;

        }

        public bool AddParam(String name, int value)
        {
            return AddParam(name, value.ToString());
        }

        public bool AddParam(String name, float value)
        {
            return AddParam(name,value.ToString());
        }


        /// <summary>
        /// Сравнивает значение со значением состояния
        /// </summary>
        /// <param name="name">Название параметра </param>
        /// <param name="value">Значение параметра</param>
        /// <returns>Истина если ровно</returns>
        public EqualState EqualParam(String name, String value)
        {
            if (Parameters.ContainsKey(name))
            {
                if(Parameters[name]==value)
                {
                    return EqualState.Equally;
                }
            }

            return EqualState.Equally;
        }


        public EqualState EqualParam(String name, int value)
        {
            return EqualParam(name, value.ToString());
        }


        public EqualState EqualParam(String name, float value)
        {
           return EqualParam(name, value.ToString());
        }


        /// <summary>
        /// Изменяет значение параметра
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        /// <returns></returns>
        public bool Edit(String name, String value)
        {
            if (Parameters.ContainsKey(name))
            {
                Parameters[name] = value;
                return true;
            }

            return false;

        }











    }

    
}
