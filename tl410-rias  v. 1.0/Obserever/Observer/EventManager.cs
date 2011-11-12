using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
    public class EventManager
    {
        private State _state;
        
        public EventManager()
        {
            State = new State();

        }

        public State State
        {
            get { return _state;
                
            }
            set { _state = value;
            _state.Notify();
            }
        }


        public void LoadScripts()
        {


        }

        public void AddEvent(String name, SortedList<String, String> param)
        {



            var aevent = new AviaEvent(_state, name, param);
            _state.Attach(aevent);
            aevent.Execute += new EventHandler(aevent_Execute);

        }

        private void aevent_Execute(string eventName, string paramName)
        {
            MessageBox.Show(String.Format("Подія {0} відбулась при збіганні параметра {1}", eventName, paramName));
        }


        public void ChangeStateParam(String name, String value)
        {
            State.Edit(name, value);
            State.Notify();
        }

    }
}
