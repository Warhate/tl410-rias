using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
    public abstract class Observer
    {
        public abstract void Update();

    }


    /// <summary>
    /// Делегат для собития исполнения собития (как говорит порутчик Ржевский: каламбурчик)
    /// </summary>
    /// <param name="eventName">Имя события</param>
    /// <param name="paramName">Имя параметра из-за каторого это событие произошло</param>
    public delegate void EventHandler(String eventName, String paramName);



    public class AviaEvent : Observer
    {
        public event EventHandler Execute;

        #region Variables

        /// <summary>
        /// Название события
        /// </summary>
        private string _name;

        /// <summary>
        /// Осуществилось ли событие
        /// </summary>
        bool _done;

        /// <summary>
        /// Состояние ЛА
        /// </summary>
        private State _state;

        /// <summary>
        /// Параметры события
        /// </summary>
        private SortedList<String,String> _eventState;

        /// <summary>
        /// Является ли событие повторяющимся
        /// </summary>
        private bool _isSingle;

        /// <summary>
        /// Интервал с которым повторяется событие
        /// </summary>
        private int _interval = 1000;

        /// <summary>
        /// Время прошедшее с момента осуществления события
        /// </summary>
        private int _time;

        #endregion

        #region Constructor

        public AviaEvent(State state, string name, SortedList<String,String> eventState)
        {
            _name = name;
            _state = state;
            _eventState = eventState;
            Execute += AviaEventExecute;


        }

        #endregion

        /// <summary>
        /// Когда событие осуществляется
        /// </summary>
        /// <param name="eventName">Имя события</param>
        /// <param name="paramName">Имя параметра</param>
        void AviaEventExecute(string eventName, string paramName)
        {
            _done = true;
        }

        /// <summary>
        /// Получения сосояния ЛА и сравнение с сосоянием события
        /// </summary>
        public override void Update()
        {
            _time += DateTime.UtcNow.Millisecond; //таймер
            if(!IsSingle&&_time>_interval)
            {
                _done = false;
                _time = 0;
            }

            if (!_done)
            {
                foreach (var param in _eventState)
                {
                    if (_state.EqualParam(param.Key, param.Value) == EqualState.Equally)
                    {
                        //todo: add logger interface
                        Logger.SendMessage("Event: "+_name + ".Equally. Param: "+ param.Key+" = "+param.Value);
                        Execute(_name + " Equally", param.Key);
                    }
                }
            }
        }

        /// <summary>
        /// Состояние ЛА которое содержит событие
        /// </summary>
        public State ObserverState
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        /// Повторяется событие или нет
        /// </summary>
        public bool IsSingle
        {
            get { return _isSingle; }
            set { _isSingle = value; }
        }

        /// <summary>
        /// Интервал с которым событие повторяется
        /// </summary>
        public int Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }
    }
}
