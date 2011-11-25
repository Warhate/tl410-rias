using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
    /// <summary>
    /// Класс управления событиямы
    /// </summary>
    public class EventManager
    {
        private State _state;
        
        public EventManager()
        {
            State = new State();
        }

        public State State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                _state.Notify();
            }
        }

        public void LoadScripts()
        {
            //todo:add logic realisation loading scripts
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="name">Название события</param>
        /// <param name="param">Список параметров</param>
        public void AddEvent(String name, SortedList<String, String> param)
        {
           var aevent = new AviaEvent(_state, name, param);
            aevent.IsSingle = false;
            aevent.Interval = 20000;
            
            _state.Attach(aevent);
            aevent.Execute += new EventHandler(aevent_Execute);
        }

        private void aevent_Execute(string eventName, string paramName)
        {
            MessageBox.Show(String.Format("Подія {0} відбулась при збіганні параметра {1}", eventName, paramName));
        }

        /// <summary>
        /// Изменение состояния ЛА
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        public void ChangeStateParam(String name, String value)
        {
            State.Edit(name, value);
            State.Notify();
        }
    }
}
